import {IUserModelRemote} from "../../models-remote";
import {IBaseResponse} from "../base-response";

export interface IGetCurrentUserResponse extends IBaseResponse {
    user: IUserModelRemote
}