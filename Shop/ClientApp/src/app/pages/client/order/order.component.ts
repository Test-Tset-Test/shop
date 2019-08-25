import {Component, OnInit} from '@angular/core';
import {OrderService} from "../../../services/order.service";
import {ActivatedRoute} from "@angular/router";
import {OrderProduct} from "../../../models/order.model";

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit{
  public orders: Array<OrderProduct>;
  id: number;

  constructor(private orderService: OrderService, private activatedRoute: ActivatedRoute,) {
  }
  ngOnInit() {
    this.activatedRoute.params.subscribe(
      (event) => {
        console.log(event);
        if (event.hasOwnProperty('id')) {
          this.orderService.getOrder(event.id).subscribe(
            (response: any) => {
              return this.orders = response;
            }
          );
        }
      }
    ).unsubscribe();
  }
}
