import {CartAction, CartActionType} from "../actions";
import {ICartItem} from "../../models";
import {LocalStorageService} from "../../services";
import {localStorageKeys} from "../../constants";

export type CartItemsMap = {[id: number]: ICartItem};

export interface ICartState {
    items: CartItemsMap
}

export const initialState: ICartState = {
    items: LocalStorageService.getItem<CartItemsMap>(localStorageKeys.CART_ITEMS) || {}
};

export const cartReducer = (state: ICartState = initialState, action: CartAction): ICartState => {
    switch (action.type) {
        case CartActionType.AddToCart:
            const newItem = action.payload;

            const items = {...state.items};
            if(items[newItem.productId]) {
                items[newItem.productId].count++;
            } else {
                items[newItem.productId] = newItem;
            }
            LocalStorageService.setItem(localStorageKeys.CART_ITEMS, items);
            return {
                items
            };
        case CartActionType.RemoveItem: {
            const id = action.payload;
            let newItems = {...state.items};
            delete newItems[id];
            LocalStorageService.setItem(localStorageKeys.CART_ITEMS, newItems);
            return {
                ...state,
                items: newItems
            };
        }
        case CartActionType.ChangeItemCount: {
            const {id, diff} = action.payload;
            let itemForChange: ICartItem = state.items[id];
            if(!itemForChange)
                return state;

            const items = {...state.items};
            const newCount = itemForChange.count + diff;
            if(newCount < 0) {
                return state;
            }
            itemForChange.count = newCount;
            items[id] = {...itemForChange};
            LocalStorageService.setItem(localStorageKeys.CART_ITEMS, items);
            return {...state, items};
        }
        case CartActionType.ClearCart:
            return {
                items: {}
            };
        default:
            return state;
    }
};