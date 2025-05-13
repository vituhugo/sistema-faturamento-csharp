import { Component, OnInit } from '@angular/core';
import { LaunchService, Launch } from '../../services/launch.service';
import {CurrencyPipe, NgForOf, DatePipe, formatDate, NgIf} from '@angular/common';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-launch-list',
  templateUrl: './launch-list.component.html',
  imports: [
    NgForOf,
    FormsModule,
    CurrencyPipe,
    DatePipe,
    NgIf,
  ],
  styleUrls: ['./launch-list.component.css']
})
export class LaunchListComponent implements OnInit {
  items: Launch[] = [];
  total = 0;
  page = 1;
  size = 20;

  filter = {
    date: formatDate(new Date(), 'YYYY-MM-dd', 'en-US'),
    type: '',
    orderBy: 'date',
    orderType: 'DESC',
  };
  dictionary: Record<string, string> = { credit: 'Crédito', debit: 'Débito' }

  constructor(private service: LaunchService) {}

  ngOnInit() {
    this.load();
  }

  load() {
    this.service.list(this.page, this.size, {
      date: new Date(this.filter.date),
      type: this.filter.type as any,
      orderBy: this.filter.orderBy,
      orderType: this.filter.orderType as any,
    }).subscribe(resp => {
      this.items = resp.items;
      this.total = resp.metadata.total;
    });
  }

  changePage(delta: number) {
    this.page += delta;
    this.load();
  }

  applyFilter() {
    this.service.list(1, this.size, {
      date: new Date(this.filter.date),
      type: this.filter.type as any,
      orderBy: this.filter.orderBy,
      orderType: this.filter.orderType as any,
    }).subscribe(resp => {
      this.items = resp.items;
      this.total = resp.metadata.total;
    });
  }
}
