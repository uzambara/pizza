import {combineReducers} from "redux";
import {cartReducer, ICartState, CartItemsMap} from "./cart.reducer";
import {ISettingsState, settingsReducer} from "./settings.reducer";
import {IProductsState, productsReducer} from "./products.reducer";

export interface IGlobalState {
    cart: ICartState,
    settings: ISettingsState,
    products: IProductsState
}

export const rootReducer = combineReducers<IGlobalState>({
    cart: cartReducer,
    settings: settingsReducer,
    products: productsReducer
});

export {
    CartItemsMap
}