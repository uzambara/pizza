import {IGetAllProductsResponse} from "../contratcs/product";
import {fetchUtil} from "../utils";
import {ApiRouting} from "../routing";

export class ProductService {
    public static async  GetAll(): Promise<IGetAllProductsResponse> {
        return  await fetchUtil.get<IGetAllProductsResponse>(ApiRouting.Product.getAll);
    }
}