import { NgModule } from '@angular/core';

import {RouterModule} from '@angular/router';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {StatisticsComponent} from "./statistics.component";
import {CustomChartModule} from "../../../components/custom-chart/custom-chart.module";

@NgModule({
  declarations: [StatisticsComponent],
  imports: [CommonModule, FormsModule, RouterModule, CustomChartModule],
  exports: [StatisticsComponent],
  providers: [/*RegService*/],
})
export class StatisticsModule {
}
