import {combineReducers} from "redux";
import {cartReducer, ICartState, CartItemsMap} from "./cart.reducer";
import {ISettingsState, settingsReducer} from "./settings.reducer";

export interface IGlobalState {
    cart: ICartState,
    settings: ISettingsState
}

export const rootReducer = combineReducers<IGlobalState>({
    cart: cartReducer,
    settings: settingsReducer
});

export {
    CartItemsMap
}