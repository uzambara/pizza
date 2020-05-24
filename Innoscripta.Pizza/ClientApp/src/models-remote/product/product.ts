import {ProductType} from "../../enums";

export interface IProductModelRemote {
    id: number,
    name: string,
    price: number,
    img: string,
    description: string,
    type: ProductType
}