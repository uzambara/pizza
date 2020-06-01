import {IBaseResponse} from "../base-response";
import {IUserModelRemote} from "../../models-remote";

export interface IRegisterResponse extends IBaseResponse {
    user: IUserModelRemote
}