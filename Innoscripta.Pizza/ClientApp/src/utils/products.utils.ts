import memoize from "memoizee";
import {IProductModelRemote} from "../models-remote";
import {LanguageType, ProductType} from "../enums";

const getProductsByType = memoize((products: IProductModelRemote[], type: ProductType) => {
    return products.filter(product => product.type == type)
});

const getNameAndDescription = (productModel: IProductModelRemote, lang: LanguageType): {name: string, description: string} => {
    switch (lang) {
        case LanguageType.ENG:
            return {
                description: productModel.descriptionEng,
                name: productModel.nameEng
            };
        case LanguageType.RUS:
            return {
                description: productModel.descriptionRu,
                name: productModel.nameRu
            };
        default:
            return {
                description: productModel.descriptionEng,
                name: productModel.nameEng
            };
    }
};



export const productUtils = {
    getProductsByType,
    getNameAndDescription
};