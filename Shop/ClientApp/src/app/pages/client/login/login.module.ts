import {NgModule} from '@angular/core';
import {RouterModule} from '@angular/router';
import {FormsModule} from '@angular/forms';
import {CommonModule} from '@angular/common';

import {LoginComponent} from './login.component';

@NgModule({
  declarations: [LoginComponent],
  imports: [RouterModule, FormsModule, CommonModule],
  exports: [LoginComponent],
  providers: [],
})
export class LoginModule {
}
