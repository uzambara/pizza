import {IGlobalState} from "../reducers";

function selectCurrencyType(state: IGlobalState) {
    return state.settings.currencyType
}

export const settingsSelectors = {
    selectCurrencyType
};