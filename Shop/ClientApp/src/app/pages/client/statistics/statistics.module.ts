import {NgModule} from '@angular/core';

import {RouterModule} from '@angular/router';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {RegService} from '../../../services/reg.service';
import {StatisticsComponent} from "./statistics.component";

@NgModule({
  declarations: [StatisticsComponent],
  imports: [CommonModule, FormsModule, RouterModule],
  exports: [StatisticsComponent],
  providers: [RegService],
})
export class StatisticsModule {
}
