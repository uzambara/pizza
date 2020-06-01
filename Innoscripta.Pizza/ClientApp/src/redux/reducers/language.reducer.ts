import {englishStrings, IContentStrings, russianStrings} from "../../content-strings";
import {LanguageType} from "../../enums";
import {LanguageAction, LanguageActionType} from "../actions";
import {getLanguageBuilder} from "../../factories";

export interface ILanguageState {
    contentStrings: IContentStrings,
    languageType: LanguageType
}

const initialState: ILanguageState ={
    contentStrings: englishStrings,
    languageType: LanguageType.ENG
};

export function languageReducer(state: ILanguageState = initialState, action: LanguageAction): ILanguageState {
    switch (action.type) {
        case LanguageActionType.SetLanguage: {
            const langStateBuilder = getLanguageBuilder(action.payload);
            return langStateBuilder();
        }
        default:
            return state;
    }
}