import {LanguageType} from "../enums";
import {Images} from "../images";

function getLanguageImageByType(languageType: LanguageType) {
    switch (languageType) {
        case LanguageType.ENG:
            return Images.Languages.english;
        case LanguageType.RUS:
            return Images.Languages.russian;
    }
}

export const languageUtils = {
    getLanguageImageByType
};