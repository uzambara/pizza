import {IProductModelRemote} from "../../models-remote";
import {Dispatch} from "redux";
import {ProductService} from "../../services";

export type ProductsActions = IAddProducts;

export enum ProductsActionsType {
    AddProducts = "ADD_PRODUCTS"
}

const fetchProductsRemote = () => async (dispatch: Dispatch) => {
    const response = await ProductService.GetAll();
    if(response.products.length > 0) {
        dispatch(AddProducts(response.products));
    }
};

interface IAddProducts {
    type: ProductsActionsType.AddProducts,
    payload: IProductModelRemote[]
}

function AddProducts(products: IProductModelRemote[]): IAddProducts {
    return {
        type: ProductsActionsType.AddProducts,
        payload: products
    }
}

export const productsActions = {
    fetchProductsRemote
};