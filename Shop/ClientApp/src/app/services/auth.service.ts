import {Injectable} from '@angular/core';
import {Router} from '@angular/router';

import {AuthApiService} from '../api/auth.api.service';

@Injectable()
export class AuthService {
  constructor(private authApi: AuthApiService, private router: Router) {
  }

  login = (user) => {
    return this.authApi.login(user);
  };
}
