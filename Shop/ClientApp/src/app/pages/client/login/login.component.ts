import {Component, OnInit, ViewChild} from '@angular/core';
import {NgForm} from '@angular/forms';
import {Router} from '@angular/router';
import {AuthService} from '../../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html'
})

export class LoginComponent implements OnInit {
  user = {} as UserAuthModel;
  errorsForm = {} as UserAuthFormModel;
  @ViewChild('loginForm')
  loginForm: NgForm;

  constructor(private router: Router, private authService: AuthService) {

  }

  onSubmit({value, valid}): { value: UserAuthModel, valid: boolean } {
    const validFormLogin: object = this.loginForm.controls;
    if (this.checkValidate(validFormLogin, valid)) {
      value['remember'] = true;
      this.authService.login(value).subscribe(
        (response: UserAuthTokenModel) => {
          window.localStorage.setItem('authToken', '' + response.token + '');
          this.router.navigate(['home']);
        },
        error => {
          this.errorsForm.password = 'Неправильный логин или пароль.';
        }
      );
    } else {
      console.log('False');
    }
    return;
  }

  changeF({value, valid}): { value: UserAuthModel, valid: boolean } {
    const validFormLogin: object = this.loginForm.controls;
    this.checkValidate(validFormLogin, valid);
    return;
  }

  checkValidate(validFormLogin, valid): boolean {
    for (const item in validFormLogin) {
      if (validFormLogin.hasOwnProperty(item) && (validFormLogin[item].errors !== null)) {
        for (const error in validFormLogin[item].errors) {
          if (validFormLogin[item].errors.hasOwnProperty(error)) {
            switch (error) {
              case 'minlength':
                this.errorsForm[item] = 'Значение «Логин» должно содержать минимум ' +
                  +validFormLogin[item].errors.minlength.requiredLength + ' символа';
                break;
              case 'required':
                this.errorsForm[item] = 'Заполните поле';
                break;
              case 'email':
                this.errorsForm[item] = 'Введите корректный E-Mail';
                break;
            }
          }
        }
      } else {
        this.errorsForm[item] = '';
      }
    }

    if (valid) {
      return true;
    } else {
      return false;
    }

  }

  ngOnInit() {
  }
}
