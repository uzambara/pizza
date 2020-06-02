import memoize from "memoizee";
import {CartItemsMap} from "../redux/reducers";
import {ICartItem} from "../models";

const calcTotalPrice = memoize((cart: CartItemsMap): number => {
    let result = 0;
    for(let id in cart) {
        const cartItem = cart[id];
        result += cartItem.count * cartItem.price;
    }

    return result;
});

function cartItemsMapToArray(cartItemsMap: CartItemsMap): ICartItem[] {
    if(cartItemsMap == null)
        return [];
    return Object.values(cartItemsMap);
}

function cartItemsArrayToMap(cartItems: ICartItem[]): CartItemsMap {
    if(!cartItems) {
        return {};
    }
    const result = {};
    cartItems.forEach(item => {result[item.productId] = item})
    return result;
}

export const cartUtils = {
    calcTotalPrice,
    cartItemsMapToArray,
    cartItemsArrayToMap
};