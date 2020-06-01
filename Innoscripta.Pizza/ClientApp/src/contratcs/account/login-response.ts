import {IBaseResponse} from "../base-response";
import {IUserModelRemote} from "../../models-remote";

export interface ILoginResponse extends IBaseResponse {
    user: IUserModelRemote
}