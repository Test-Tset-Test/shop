import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../models/order';

@Injectable()
export class OrderService {

  private url = "/api/order";

  constructor(private http: HttpClient) {
  }

  getOrders() {
    return this.http.get(this.url);
  }

  createOrder(product: Order) {
    return this.http.post(this.url, product);
  }
  updateOrder(order: Order) {

    return this.http.put(this.url + '/' + order.id, order);
  }
  deleteOrder(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
