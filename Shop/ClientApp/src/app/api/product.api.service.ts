import {Injectable} from '@angular/core';
import {BaseApiService} from './base.api.service';
import {HttpEvent} from '@angular/common/http';
import {Observable} from 'rxjs';
import {ProductModel} from "../models/procuct.model";
import {AuthApiService} from "./auth.api.service";

@Injectable()
export class ProductsApiService {
  constructor(private baseService: BaseApiService, private authApiService: AuthApiService) {
  }

  getDataProductsList = (): Observable<HttpEvent<ProductModel>> => {
    const myHeaders = {'x-auth-token': this.authApiService.getToken()};
    const myParams = new URLSearchParams();
    return this.baseService.get<ProductModel>('/products', {headers: myHeaders, params: myParams});
  }
}
