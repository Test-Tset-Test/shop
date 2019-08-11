import {NgModule} from '@angular/core';

import {CommonModule} from "@angular/common";
import {ProductsComponent} from "./products.component";

@NgModule({
  declarations: [ProductsComponent],
  imports: [CommonModule],
  exports: [ProductsComponent],
  providers: [],
})
export class ProductsModule {
}
