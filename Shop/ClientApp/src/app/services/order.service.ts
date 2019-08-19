import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {OrderModel} from "../models/order.model";

@Injectable()
export class OrderService {

  private url = "/api/orders";

  constructor(private http: HttpClient) {
  }

  getOrders() {
    return this.http.get(this.url);
  }

  createOrder(product: OrderModel) {
    return this.http.post(this.url, product);
  }
  updateOrder(order: OrderModel) {

    return this.http.put(this.url + '/' + order.id, order);
  }
  deleteOrder(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
