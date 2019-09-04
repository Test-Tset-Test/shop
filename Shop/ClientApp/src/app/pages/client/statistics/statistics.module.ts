import { NgModule } from '@angular/core';

import {RouterModule} from '@angular/router';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {StatisticsComponent} from "./statistics.component";
import {CustomChartModule} from "../../../components/custom-chart/custom-chart.module";
import {FilterModule} from "../../../components/filter/filter.module";

@NgModule({
  declarations: [StatisticsComponent],
  imports: [CommonModule, FormsModule, RouterModule, CustomChartModule, FilterModule],
  exports: [StatisticsComponent],
  providers: [/*RegService*/],
})
export class StatisticsModule {
}
