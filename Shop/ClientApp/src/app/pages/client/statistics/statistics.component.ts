import {Component, OnInit} from '@angular/core';
import {log} from "util";

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent {
  public type = 'line';
  public data = {
    // Labels should be Date objects
    labels: ['2017-10-16', new Date(2017, 10, 17), new Date(2017, 10, 30)],
    datasets: [{
      fill: false,
      label: 'Page Views',
      data: [280, 250, 340],
      borderColor: '#fe8b36',
      backgroundColor: '#fe8b36',
      lineTension: 0,
    }]
  };
  public options = {
    fill: false,
    responsive: true,
    scales: {
      xAxes: [{
        type: 'time',
        display: true,
        scaleLabel: {
          display: true,
          labelString: "Date",
        }
      }],
      yAxes: [{
        ticks: {
          beginAtZero: true,
        },
        display: true,
        scaleLabel: {
          display: true,
          labelString: "Page Views",
        }
      }]
    }
  };
  public dataForm = {
    body: {
      class: '.panel__content',
      fields: [
        {
          id: 'select-table',
          name: 'Выберите таблицу',
          placeholder: '',
          type: 'selectbox',
          classes: 'form-control form-control-sm',
          data: [{id: "test", name: "test", class: {'first': true}}],
          selected: ''
        },
        {
          id: 'from-date',
          name: 'От',
          placeholder: '',
          type: 'date',
          classLabel: 'form-group',
          classInput: 'form-control form-control-sm',
          data: {},
          selected: ''
        },
        {
          id: 'to-date',
          name: 'До',
          placeholder: '',
          type: 'date',
          classLabel: 'form-group',
          classInput: 'form-control form-control-sm',
          data: {},
          selected: ''
        },
      ]
    },
    button: {
      classDiv: '',
      name: 'Применить',
      classButton: 'btn btn-success',
      type: 'button'
    }
  };

  constructor() {
  }

  changeType(type: string) {
    this.type = type;
  }

  filterTables(filter: object) {
    debugger;
    console.log(filter);
  }

  changeFilter() {

  }

}
