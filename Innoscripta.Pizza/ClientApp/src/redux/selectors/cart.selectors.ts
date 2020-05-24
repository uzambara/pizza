import {IGlobalState} from "../reducers";

export function selectCart(state: IGlobalState) {
    return state.cart
}

export const cartSelectors = {
    selectCart
};