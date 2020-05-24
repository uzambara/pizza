import {ICartItem} from "../../models";

export type CartAction =
    IAddToCart;

export enum CartActionType {
    AddToCart= "ADD_TO_CART"
}

export interface IAddToCart {
    type: CartActionType.AddToCart,
    payload: ICartItem
}

function AddToCart(item: ICartItem): IAddToCart {
    return {
        type: CartActionType.AddToCart,
        payload: item
    }
}

export const cartActions = {
    AddToCart
};