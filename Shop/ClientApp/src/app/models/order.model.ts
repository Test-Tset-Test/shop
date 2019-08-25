export class OrderModel {
  constructor(
    public id?: number,
    public userId?: number,
  ) {}
}
export class OrderProduct {
  constructor(
    public count?: number,
    public order?: number,
    public orderId?: number,
    public product?: number,
    public productId?: number,
  ) {}
}
