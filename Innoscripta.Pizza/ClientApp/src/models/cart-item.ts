import {ProductType} from "../enums";

export interface ICartItem {
    productId: number,
    price: number,
    name: string,
    imageUrl: string,
    count: number,
    productType: ProductType
}