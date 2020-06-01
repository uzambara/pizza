import {IMakeOrderRequest, IMakeOrderResponse, IOrderPosition} from "../contratcs/order";
import {fetchUtil} from "../utils";
import {ApiRouting} from "../routing";
import {IMakeOrderFormData} from "../models";

export class OrderService {
    public static async MakeOrder(orderItems: IOrderPosition[], orderFormData: IMakeOrderFormData): Promise<IMakeOrderResponse> {
        const requestData: IMakeOrderRequest = {
            orderPositions: orderItems,
            ...orderFormData
        };

        return await fetchUtil.post<IMakeOrderResponse>(ApiRouting.Order.create, requestData);
    }
}