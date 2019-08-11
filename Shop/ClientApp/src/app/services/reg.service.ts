import {Injectable} from '@angular/core';
import {Router} from '@angular/router';
import {BaseApiService} from '../api/base.api.service';

@Injectable()
export class RegService {

  constructor(private router: Router, private baseApi: BaseApiService) {
  }

  registrationUser = (data) => {
    return this.baseApi.post('/registration', data);
  };
}
