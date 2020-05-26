import {combineReducers} from "redux";
import {cartReducer, ICartState, CartItemsMap} from "./cart.reducer";
import {ISettingsState, settingsReducer} from "./settings.reducer";
import {IProductsState, productsReducer} from "./products.reducer";
import { reducer as formReducer } from 'redux-form';

export interface IGlobalState {
    cart: ICartState,
    settings: ISettingsState,
    products: IProductsState,
    form: any
}

export const rootReducer = combineReducers<IGlobalState>({
    cart: cartReducer,
    settings: settingsReducer,
    products: productsReducer,
    form: formReducer
});

export {
    CartItemsMap
}