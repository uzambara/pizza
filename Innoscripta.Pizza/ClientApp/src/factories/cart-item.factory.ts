import {IProductModelRemote} from "../models-remote";
import {ICartItem} from "../models";
import {IOrderItemModel} from "../contratcs/order";

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

function createOrderItem(cartItem: ICartItem): IOrderItemModel {
    return {
        count: cartItem.count,
        price: cartItem.price,
        productId: cartItem.productId
    }
}

export const cartItemFactory = {
    createCartItem,
    createOrderItem
};