import {ICartItem, IMakeOrderFormData} from "../../models";
import {IGlobalState} from "../reducers";
import {Dispatch} from "redux";
import {OrderService} from "../../services/order.service";
import {cartUtils, responseHandleUtils} from "../../utils";
import {cartItemFactory} from "../../factories";

const makeOrderRemote = (orderFormData: IMakeOrderFormData) => async (dispatch: Dispatch, getState: () => IGlobalState) => {
    const cartItems: ICartItem[] = cartUtils.cartItemsMapToArray(getState().cart.items);
    const orderItems = cartItems.map(cartItemFactory.createOrderItem);
    const response = await OrderService.MakeOrder(orderItems, orderFormData);
    responseHandleUtils.order.handleCreateOrder(response);
};

export const orderActions = {
    makeOrderRemote
};

