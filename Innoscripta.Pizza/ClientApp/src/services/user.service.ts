import {fetchUtil} from "../utils";
import {ApiRouting} from "../routing";
import {IGetOrderHistoryResponse} from "../contratcs/user";
import {IGetUserStatisticResponse} from "../contratcs/user/get-user-statistic-response";

export class UserService {
    public static async GetOrderHistory(): Promise<IGetOrderHistoryResponse> {
        return await fetchUtil.get<IGetOrderHistoryResponse>(ApiRouting.User.orderHistory);
    }

    public static async GetStatistic(): Promise<IGetUserStatisticResponse> {
        return await fetchUtil.get<IGetUserStatisticResponse>(ApiRouting.User.statistic);
    }
}