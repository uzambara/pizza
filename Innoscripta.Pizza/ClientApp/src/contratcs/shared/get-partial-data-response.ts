import {IBaseResponse} from "../base-response";
import {ResponseCode} from "../response-code";

export interface IGetPartialDataResponse<TData> extends IBaseResponse {
    items: Array<TData>,
    moreItemsExists: boolean,
    totalCount: number
}

export function getInitialGetPartialDataResponse<TData>(): IGetPartialDataResponse<TData> {
    return {
        code: ResponseCode.Ok,
        items: [],
        moreItemsExists: true,
        totalCount: 0
    }
}