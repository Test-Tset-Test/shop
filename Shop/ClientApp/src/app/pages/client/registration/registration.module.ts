import {NgModule} from '@angular/core';

import {RegistrationComponent} from './registration.component';
import {RouterModule} from '@angular/router';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {RegService} from '../../../services/reg.service';

@NgModule({
  declarations: [RegistrationComponent],
  imports: [CommonModule, FormsModule, RouterModule],
  exports: [RegistrationComponent],
  providers: [RegService],
})
export class RegistrationModule {
}
