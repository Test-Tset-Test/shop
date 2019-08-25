import {Injectable} from '@angular/core';
import {HttpClient, HttpEvent} from '@angular/common/http';
import {OrderModel} from "../models/order.model";
import {Observable} from "rxjs";
import {BaseApiService} from "../api/base.api.service";
import {AuthApiService} from "../api/auth.api.service";

@Injectable()
export class OrderService {
  constructor(private baseService: BaseApiService, private authApiService: AuthApiService) {
  }

  getOrders = (): Observable<HttpEvent<OrderModel>> => {
    const myHeaders = {'Authorization': "Bearer " + this.authApiService.getToken()};
    const myParams = new URLSearchParams();
    return this.baseService.get<OrderModel>('/orders/list', {headers: myHeaders, params: myParams});
  };

  getOrder = (orderId: number): Observable<HttpEvent<OrderModel>> => {
    const myHeaders = {'Authorization': "Bearer " + this.authApiService.getToken()};
    const myParams = {id: orderId};
    return this.baseService.get<OrderModel>('/orders/order', {headers: myHeaders, params: myParams});
  }
}
