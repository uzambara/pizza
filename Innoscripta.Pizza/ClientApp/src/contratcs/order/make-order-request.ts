export interface IOrderPosition {
    productId: number,
    price: number,
    count: number
}

export interface IMakeOrderRequest {
    orderPositions: Array<IOrderPosition>,
    address: string,
    name: string,
    lastName: string,
    phone: string,
    comment: string,
}