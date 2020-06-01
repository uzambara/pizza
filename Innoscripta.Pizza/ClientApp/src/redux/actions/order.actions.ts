import {ICartItem, IMakeOrderFormData} from "../../models";
import {IGlobalState} from "../reducers";
import {Dispatch} from "redux";
import {OrderService} from "../../services";
import {cartUtils, responseHandleUtils} from "../../utils";
import {cartItemFactory} from "../../factories";
import {ResponseCode} from "../../contratcs";
import {cartActions} from "./index";

const makeOrderRemote = (orderFormData: IMakeOrderFormData) => async (dispatch: Dispatch, getState: () => IGlobalState) => {
    const state = getState();
    const cartItems: ICartItem[] = cartUtils.cartItemsMapToArray(getState().cart.items);
    const orderItems = cartItems.filter(item => item.count > 0).map(cartItemFactory.createOrderPosition);
    const response = await OrderService.MakeOrder(orderItems, orderFormData);
    if(response.code == ResponseCode.Ok) {
        dispatch(cartActions.clearCart())
    }
    responseHandleUtils.order.handleCreateOrder(response, state.language.contentStrings);
};

export const orderActions = {
    makeOrderRemote
};

