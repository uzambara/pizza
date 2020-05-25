import {CartItemsMap, IGlobalState} from "../reducers";
import {cartUtils} from "../../utils";

export function selectCartItemsMap(state: IGlobalState): CartItemsMap {
    return state.cart.items
}

export function selectTotalPrice(state: IGlobalState) {
    return cartUtils.calcTotalPrice(state.cart.items);
}

export const cartSelectors = {
    selectCartItemsMap,
    selectTotalPrice
};