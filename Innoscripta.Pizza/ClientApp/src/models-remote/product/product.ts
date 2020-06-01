import {ProductType} from "../../enums";

export interface IProductModelRemote {
    id: number,
    nameRu: string,
    nameEng: string,
    price: number,
    img: string,
    descriptionRu: string,
    descriptionEng: string,
    type: ProductType
}