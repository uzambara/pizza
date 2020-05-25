import {IProductModelRemote} from "../models-remote";

export interface IMenuPageProps {
    products: IProductModelRemote[],
    header: string
}