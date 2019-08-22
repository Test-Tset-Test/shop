import {NgModule} from '@angular/core';

import {OrderComponent} from './order.component';
import {RouterModule} from '@angular/router';
import {CommonModule} from "@angular/common";

@NgModule({
  declarations: [OrderComponent],
  imports: [RouterModule, CommonModule],
  exports: [OrderComponent],
  providers: [],
})
export class OrderModule {
}
