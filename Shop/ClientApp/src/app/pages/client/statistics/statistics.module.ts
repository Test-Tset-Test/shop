import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';

import {RouterModule} from '@angular/router';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {StatisticsComponent} from "./statistics.component";


import { ChartModule } from 'angular-highcharts';
@NgModule({
  declarations: [StatisticsComponent],
  imports: [CommonModule, FormsModule, RouterModule,ChartModule],
  exports: [StatisticsComponent],
  providers: [/*RegService*/],
})
export class StatisticsModule {
}
