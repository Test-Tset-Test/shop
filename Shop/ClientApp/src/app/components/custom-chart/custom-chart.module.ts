import {NgModule} from '@angular/core';

import {CastomChartComponent} from './castom-chart.component'
import {CommonModule} from '@angular/common';
import {ChartModule} from "angular2-chartjs";

@NgModule({
  declarations: [CastomChartComponent],
  imports: [CommonModule,ChartModule],
  exports: [CastomChartComponent],
  providers: [],
})
export class CustomChartModule {
}
