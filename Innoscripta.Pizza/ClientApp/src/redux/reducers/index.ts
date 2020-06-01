import {combineReducers} from "redux";
import {cartReducer, ICartState, CartItemsMap} from "./cart.reducer";
import {ISettingsState, settingsReducer} from "./settings.reducer";
import {IProductsState, productsReducer} from "./products.reducer";
import { reducer as formReducer } from 'redux-form';
import {ILanguageState, languageReducer} from "./language.reducer";
import {IUserState, UserReducer} from "./user.reducer";

export interface IGlobalState {
    cart: ICartState,
    settings: ISettingsState,
    products: IProductsState,
    form: any,
    language: ILanguageState,
    user: IUserState
}

export const rootReducer = combineReducers<IGlobalState>({
    cart: cartReducer,
    settings: settingsReducer,
    products: productsReducer,
    form: formReducer,
    language: languageReducer,
    user: UserReducer
});

export {
    CartItemsMap
}