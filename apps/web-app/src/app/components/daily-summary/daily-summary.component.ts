import { Component, OnInit } from '@angular/core';
import {DailySummary, Launch, LaunchService, PaginateResponse} from '../../services/launch.service';
import {CurrencyPipe, DatePipe, NgForOf} from '@angular/common';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-daily-summary',
  templateUrl: './daily-summary.component.html',
  imports: [
    NgForOf,
    DatePipe,
    CurrencyPipe,
    FormsModule,
  ],
  styleUrls: ['./daily-summary.component.css']
})
export class DailySummaryComponent implements OnInit {
  total = 0;
  page = 1;
  size = 5;

  summary: PaginateResponse<DailySummary> = { items: [], metadata: { total: 0 }};

  constructor(private service: LaunchService) {}

  ngOnInit() {
    this.load()
  }

  load() {
    this.service.dailySummary(this.page, this.size).subscribe(res => {
      this.summary = res
      this.total = res.metadata.total
    });
  }

  changePage(delta: number) {
    this.page += delta;
    this.load();
  }


  applyFilter() {
    this.service.dailySummary(1, this.size).subscribe(resp => {
      this.summary = resp;
      this.total = resp.metadata.total;
    });
  }
}
