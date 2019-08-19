import {Injectable} from '@angular/core';
import {BaseApiService} from './base.api.service';
import {HttpEvent} from '@angular/common/http';
import {Observable} from 'rxjs';
import {ProductModel} from "../models/procuct.model";
import {AuthApiService} from "./auth.api.service";
import {OrdersModule} from "../pages/client/orders/orders.module";

@Injectable()
export class ProductsApiService {
  constructor(private baseService: BaseApiService, private authApiService: AuthApiService) {
  }

  getDataOrdersList = (): Observable<HttpEvent<OrdersModule>> => {
    const myHeaders = {'Authorization': "Bearer "+this.authApiService.getToken()};
    const myParams = new URLSearchParams();
    return this.baseService.get<ProductModel>('/orders', {headers: myHeaders, params: myParams});
  }
}
