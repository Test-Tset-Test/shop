import { NgModule } from '@angular/core';

import {RouterModule} from '@angular/router';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {StatisticsComponent} from "./statistics.component";
import {ChartModule} from "angular2-chartjs";

@NgModule({
  declarations: [StatisticsComponent],
  imports: [CommonModule, FormsModule, RouterModule, ChartModule],
  exports: [StatisticsComponent],
  providers: [/*RegService*/],
})
export class StatisticsModule {
}
