import {NgModule} from '@angular/core';

import {OrdersComponent} from './orders.component';
import {RouterModule} from '@angular/router';
import {CommonModule} from "@angular/common";

@NgModule({
  declarations: [OrdersComponent],
  imports: [RouterModule, CommonModule],
  exports: [OrdersComponent],
  providers: [],
})
export class OrdersModule {
}
