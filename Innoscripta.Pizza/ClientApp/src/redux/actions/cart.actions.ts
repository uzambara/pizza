import {CartItemsMap} from "../reducers";
import {ICartItem} from "../../models";

export type CartAction =
    IAddToCart
    | IRemoveItem
    | IChangeItemCount
    | IClearCart
    | ISetCartItemsMap;

export enum CartActionType {
    SetCartItemsMap = "SET_CART_ITEMS_MAP",
    AddToCart = "ADD_TO_CART",
    RemoveItem = "REMOVE_ITEM",
    ChangeItemCount = "CHANGE_ITEM_COUNT",
    ClearCart = "CLEAR_CART"
}

export interface ISetCartItemsMap {
    type: CartActionType.SetCartItemsMap,
    payload: CartItemsMap
}

function setCartItemsMap(map: CartItemsMap): ISetCartItemsMap {
    return {
        type: CartActionType.SetCartItemsMap,
        payload: map
    }
}

export interface IAddToCart {
    type: CartActionType.AddToCart,
    payload: ICartItem
}

function addToCart(item: ICartItem): IAddToCart {
    return {
        type: CartActionType.AddToCart,
        payload: item
    }
}

export interface IRemoveItem {
    type: CartActionType.RemoveItem,
    payload: number
}

function removeItem(id: number): IRemoveItem {
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

function changeItemCount(id: number, diff: number): IChangeItemCount {
    return {
        type: CartActionType.ChangeItemCount,
        payload: {
            id,
            diff
        }
    }
}

export interface IClearCart {
    type: CartActionType.ClearCart,
    payload: null
}

function clearCart(): IClearCart {
    return {
        type: CartActionType.ClearCart,
        payload: null
    }
}

export const cartActions = {
    addToCart,
    removeItem,
    changeItemCount,
    clearCart,
    setCartItemsMap
};