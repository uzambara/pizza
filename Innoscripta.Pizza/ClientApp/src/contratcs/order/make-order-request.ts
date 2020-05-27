export interface IOrderItemModel {
    productId: number,
    price: number,
    count: number
}

export interface IMakeOrderRequest {
    orderPositions: Array<IOrderItemModel>,
    address: string,
    name: string,
    lastName: string,
    phone: string,
    comment: string,
}