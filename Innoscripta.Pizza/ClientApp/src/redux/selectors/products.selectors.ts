import {IGlobalState} from "../reducers";
import {IProductModelRemote} from "../../models-remote";

function selectProductItems(state: IGlobalState): IProductModelRemote[] {
    return state.products.items;
}

export const productsSelectors = {
    selectProductItems
};