import {IProductModelRemote} from "../../models-remote";
import {IBaseResponse} from "../base-response";

export interface IGetAllProductsResponse extends IBaseResponse {
    products: IProductModelRemote[]
}