import {NgModule} from '@angular/core';
import {HomeComponent} from './home.component';
import {CommonModule} from '@angular/common';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule, HttpClientModule
  ],
  exports: [
    HomeComponent
  ],
  providers: []
})

export class HomeModule {
}
