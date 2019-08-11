import {NgModule} from '@angular/core';

import {NavMenuComponent} from './nav-menu.component';
import {RouterModule} from '@angular/router';
import {CommonModule} from "@angular/common";

@NgModule({
  declarations: [NavMenuComponent],
  imports: [RouterModule, CommonModule],
  exports: [NavMenuComponent],
  providers: [],
})
export class NavMenuModule {
}
