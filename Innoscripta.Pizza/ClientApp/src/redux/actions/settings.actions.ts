import {CurrencyType} from "../../enums";

export type SettingsAction =
    IChangeCurrencyType;


export enum SettingsActionType {
    ChangeCurrencyType = "CHANGE_CURRENCY_TYPE"
}

export interface IChangeCurrencyType {
    type: SettingsActionType.ChangeCurrencyType
    payload: CurrencyType
}

function changeCurrencyType(currencyType: CurrencyType): IChangeCurrencyType {
    return {
        type: SettingsActionType.ChangeCurrencyType,
        payload: currencyType
    }
}

export const settingsActions = {
    changeCurrencyType
};