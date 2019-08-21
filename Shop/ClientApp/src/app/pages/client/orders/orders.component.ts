import {Component, OnInit} from '@angular/core';
import {OrderService} from "../../../services/order.service";
import {OrderModel} from "../../../models/order.model";

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit{
  public orders: Array<OrderModel>;

  constructor(private orderService: OrderService) {
  }
  ngOnInit() {
    this.orderService.getOrders().subscribe(
      (response: any) => {
        return this.orders = response;
      }
    )
  }
}
