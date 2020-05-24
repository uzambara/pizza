import {CurrencyType} from "../../enums";
import {SettingsAction, SettingsActionType} from "../actions";

export interface ISettingsState {
    currencyType: CurrencyType
}

const initialState: ISettingsState = {
    currencyType: CurrencyType.USD
};

export function settingsReducer(state: ISettingsState = initialState, action: SettingsAction): ISettingsState {
    switch (action.type) {
        case SettingsActionType.ChangeCurrencyType:
            return {
                currencyType: action.payload
            };
        default:
            return state;
    }
}