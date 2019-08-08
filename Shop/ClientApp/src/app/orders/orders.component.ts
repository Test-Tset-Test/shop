import { Component, Inject } from '@angular/core';
import { Order } from '../models/order';
import {OrderService} from "../services/order.service";

@Component({
  selector: 'app-orders-component',
  templateUrl: './orders.component.html'
})
export class OrdersComponent {
  order: Order = new Order();
  orders: Order[];
  tableMode: boolean = true;

  constructor(private orderService: OrderService) { }

  ngOnInit() {
    this.loadProducts();
  }

  loadProducts() {
    this.orderService.getOrders()
      .subscribe((data: Order[]) => this.orders = data);
  }
}
