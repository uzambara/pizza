import {IProductModelRemote} from "../../models-remote";
import {ProductsActions, ProductsActionsType} from "../actions";

export interface IProductsState {
    items: IProductModelRemote[]
}

const initialState: IProductsState = {
    items: []
};

export function productsReducer(state: IProductsState = initialState, action: ProductsActions) : IProductsState {
    switch (action.type) {
        case ProductsActionsType.AddProducts:
            return {
                ...state,
                items: action.payload
            };
        default:
            return state;
    }
}