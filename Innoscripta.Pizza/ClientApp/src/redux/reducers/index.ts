import {combineReducers} from "redux";
import {cartReducer, ICartState, CartItemsMap, initialState as cartInitialState} from "./cart.reducer";
import {ISettingsState, settingsReducer} from "./settings.reducer";
import {IProductsState, productsReducer} from "./products.reducer";
import { reducer as formReducer } from 'redux-form';
import {ILanguageState, languageReducer} from "./language.reducer";
import {IUserState, userReducer} from "./user.reducer";

export interface IGlobalState {
    cart: ICartState,
    settings: ISettingsState,
    products: IProductsState,
    form: any,
    language: ILanguageState,
    user: IUserState
}

const rootReducer = combineReducers<IGlobalState>({
    cart: cartReducer,
    settings: settingsReducer,
    products: productsReducer,
    form: formReducer,
    language: languageReducer,
    user: userReducer
});

export {
    CartItemsMap,
    rootReducer,
    cartInitialState
}