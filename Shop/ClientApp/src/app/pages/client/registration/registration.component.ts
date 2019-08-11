import {Component, EventEmitter, OnInit, Output, ViewChild} from '@angular/core';
import {NgForm} from '@angular/forms';
import {Router} from '@angular/router';
import {RegService} from '../../../services/reg.service';

interface UserReg {
  login: string;
  email: string;
  password: string;
  password_repeat: string;
}

@Component({
  selector: 'app-registration',
  templateUrl: 'registration.component.html'
})

export class RegistrationComponent implements OnInit {
  user = {} as UserReg;
  errorsForm = {
    login: '',
    email: '',
    password: '',
    password_repeat: '',
  };
  @ViewChild('regForm')
  regForm: NgForm;

  constructor(private router: Router,  private reg: RegService) {

  }

  onSubmit({value, valid}): { value: UserReg, valid: boolean } {
    const validFormLogin: object = this.regForm.controls;
    if (this.checkValidate(validFormLogin, valid)) {
      this.reg.registrationUser(value).subscribe(
        (response) => {
          console.log(response);
        },
        (err) => {
          return err;
        }
      );
    } else {
      console.log('False');
    }
    return;
  }

  changeF({value, valid}): { value: UserReg, valid: boolean } {
    const validFormLogin: object = this.regForm.controls;
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
    if ((validFormLogin['password'].valid && validFormLogin['password_repeat'].valid)
      && (validFormLogin['password'].value !== validFormLogin['password_repeat'].value)) {
      this.errorsForm.password_repeat = 'Пароли не совпадают';
      valid = false;
    }
    return !!valid;

  }

  ngOnInit() {
  }
}
