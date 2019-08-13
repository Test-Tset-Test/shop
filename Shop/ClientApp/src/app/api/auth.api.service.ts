import {Injectable} from '@angular/core';
import {BaseApiService} from './base.api.service';
import {Observable} from 'rxjs';
import {HttpEvent} from '@angular/common/http';


@Injectable()
export class AuthApiService {

  constructor(private baseApi: BaseApiService) {
  }

  login = (userData: UserAuthModel): Observable<UserAuthTokenModel> => {
    return this.baseApi.post<UserAuthTokenModel>('/login', userData);
  };
}
