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
  getUserData = () => {
    const myHeaders = {'x-auth-token': this.authApi.getToken()};
    const myParams = new URLSearchParams();
    return this.authApi.getUserData({headers: myHeaders, params: myParams});
  };
  checkAuthUser = () => {
    return !!window.localStorage.getItem('Authorization');
  };
  logout = () => {
    window.localStorage.removeItem('authToken');
    this.router.navigate(['home']);
    return true;
  }
}
