import {LanguageType} from "../enums";
import {ILanguageState} from "../redux/reducers/language.reducer";
import {englishStrings, russianStrings} from "../content-strings";

export type LanguageStateBuilder = () => ILanguageState;

export function getLanguageBuilder(languageType: LanguageType): LanguageStateBuilder {
    switch (languageType) {
        case LanguageType.RUS:
            return russianLanguageStateBuilder;
        case LanguageType.ENG:
            return englishLanguageStateBuilder;
        default:
            return englishLanguageStateBuilder;
    }
}

const englishLanguageStateBuilder: LanguageStateBuilder = () => {
    return {
        languageType: LanguageType.ENG,
        contentStrings: englishStrings
    }
};

const russianLanguageStateBuilder: LanguageStateBuilder = () => {
    return {
        languageType: LanguageType.RUS,
        contentStrings: russianStrings
    }
};

export const languageBuilders = {
    englishLanguageStateBuilder,
    russianLanguageStateBuilder
};