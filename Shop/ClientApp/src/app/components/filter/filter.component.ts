import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';


@Component({
  selector: 'app-filter',
  templateUrl: 'filter.component.html'
})

export class FilterComponent implements OnInit {
  test = {'first': true};
  @Input() dataForm: object;
  @Output() filterTables: EventEmitter<{ filterForm: {} }> = new EventEmitter<{ filterForm: {} }>();

  enableChange() {
    this.filterTables.emit();
  }


  constructor() {
  }

  ngOnInit() {
  }
}
