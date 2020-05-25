import {ICartItem} from "../../models";

export type CartAction =
    IAddToCart
    | IRemoveItem
    | IChangeItemCount;

export enum CartActionType {
    AddToCart = "ADD_TO_CART",
    RemoveItem = "REMOVE_ITEM",
    ChangeItemCount = "CHANGE_ITEM_COUNT",
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

export interface IRemoveItem {
    type: CartActionType.RemoveItem,
    payload: number
}

export function RemoveItem(id: number): IRemoveItem {
    return {
        type: CartActionType.RemoveItem,
        payload: id
    }
}

export interface IChangeItemCount {
    type: CartActionType.ChangeItemCount,
    payload: {
        id: number,
        diff: number
    }
}

export function ChangeItemCount(id: number, diff: number): IChangeItemCount {
    return {
        type: CartActionType.ChangeItemCount,
        payload: {
            id,
            diff
        }
    }
}

export const cartActions = {
    AddToCart,
    RemoveItem,
    ChangeItemCount
};