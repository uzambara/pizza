import {ProductType} from "../enums";
import {Images} from "../images";

function getProductTypeImage(productType: ProductType): string {
    switch (productType) {
        case ProductType.Drink:
            return Images.ProductType.drinks;
        case ProductType.Pizza:
        default:
            return Images.ProductType.pizza;
    }
}



export const productTypeUtils = {
    getProductTypeImage
};