import {IOrderItemModelRemote} from "..";

export interface IOrderModelRemote {
    address: string,
    totalPrice: number,
    comment: string,
    date: string,
    orderItems: Array<IOrderItemModelRemote>
}