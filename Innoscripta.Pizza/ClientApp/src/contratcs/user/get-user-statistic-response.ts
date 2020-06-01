import {IBaseResponse} from "../base-response";
import {IUserStatisticModelRemote} from "../../models-remote";

export interface IGetUserStatisticResponse extends IBaseResponse {
    statistic: IUserStatisticModelRemote
}