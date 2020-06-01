import {IProductModelRemote} from "../models-remote";
import {ICartItem} from "../models";
import {IOrderPosition} from "../contratcs/order";
import {productUtils} from "../utils/products.utils";
import {LanguageType} from "../enums";

function createCartItem(product: IProductModelRemote, languageType: LanguageType): ICartItem {
    const {name} = productUtils.getNameAndDescription(product, languageType);
    return {
        count: 1,
        imageUrl: product.img,
        name: name,
        price: product.price,
        productId: product.id,
        productType: product.type
    }
}

function createOrderPosition(cartItem: ICartItem): IOrderPosition {
    return {
        count: cartItem.count,
        price: cartItem.price,
        productId: cartItem.productId
    }
}

export const cartItemFactory = {
    createCartItem,
    createOrderPosition
};