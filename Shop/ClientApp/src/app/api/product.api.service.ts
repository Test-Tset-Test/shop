import {Injectable} from '@angular/core';
import {BaseApiService} from './base.api.service';
import {HttpEvent} from '@angular/common/http';
import {Observable} from 'rxjs';
import {ProductModel} from "../models/procuct.model";

@Injectable()
export class ProductsApiService {
  constructor(private base: BaseApiService) {
  }

  getDataProductsList = (headers?): Observable<HttpEvent<ProductModel>> => {
    return this.base.get<ProductModel>('/products', headers);
  }
}
