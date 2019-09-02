import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';


@Component({
  selector: 'app-custom-chart',
  templateUrl: 'custom-chart.component.html'
})

export class CastomChartComponent implements OnInit {
  @Input() type: string;
  @Input() data: object;
  @Input() options: object;
  enableChange() {
  }


  constructor() {
  }

  ngOnInit() {
  }
}
