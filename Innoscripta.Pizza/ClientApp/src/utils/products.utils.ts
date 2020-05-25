import memoize from "memoizee";
import {IProductModelRemote} from "../models-remote";
import {ProductType} from "../enums";

const getProductsByType = memoize((products: IProductModelRemote[], type: ProductType) => {
    return products.filter(product => product.type == type)
});


export const productUtils = {
    getProductsByType
};