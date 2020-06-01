import {LanguageType} from "../../enums";

export type LanguageAction = ISetLanguage;

export enum LanguageActionType {
    SetLanguage = "SET_LANGUAGE"
}

export interface ISetLanguage {
    type: LanguageActionType.SetLanguage,
    payload: LanguageType
}

export const setLanguage = (language: LanguageType): ISetLanguage => ({
    type: LanguageActionType.SetLanguage,
    payload: language
});

export const languageActions = {
    setLanguage
};