import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent {
  type = 'line';
  data = {
    datasets: [{
      label: 'First dataset',
      data: [0, 50, 90, 150]
    }],
    labels: ['January', 'February', 'March', 'April']
  };
  options = {
    responsive: true,
    title:      {
      display: true,
      text:    "Chart.js Time Scale"
    },
    scales:     {
      xAxes: [{
        ticks: {
          suggestedMin: 50,
          suggestedMax: 100
        }
      }],

      yAxes: [{
        ticks: {
          max: 100,
          min: 0,
          stepSize:15
        }
      }]
    }
  };
  constructor(){
  }

  changeType(type: string){
    this.type = type;
  }

}
