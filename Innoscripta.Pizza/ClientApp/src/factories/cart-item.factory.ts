import {IProductModelRemote} from "../models-remote";
import {ICartItem} from "../models";

function createCartItem(product: IProductModelRemote): ICartItem {
    return {
        count: 1,
        imageUrl: product.img,
        name: product.name,
        price: product.price,
        productId: product.id,
        productType: product.type
    }
}

export const cartItemFactory = {
    createCartItem
};