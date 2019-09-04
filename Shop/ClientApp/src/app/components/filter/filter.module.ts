import {NgModule} from '@angular/core';

import {FilterComponent} from './filter.component';
import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';

@NgModule({
  declarations: [FilterComponent],
  imports: [CommonModule, FormsModule],
  exports: [FilterComponent],
  providers: [],
})
export class FilterModule {
}
