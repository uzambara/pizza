import {IBaseResponse} from "../base-response";
import {IOrderModelRemote} from "../../models-remote";

export interface IGetOrderHistoryResponse extends IBaseResponse{
    orderHistory: Array<IOrderModelRemote>
}