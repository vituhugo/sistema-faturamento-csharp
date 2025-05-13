import { Routes } from '@angular/router';
import {FormLaunchComponent} from './components/form-launch/form-launch.component';
import {LaunchListComponent} from './components/launch-list/launch-list.component';
import {DailySummaryComponent} from './components/daily-summary/daily-summary.component';

export const routes: Routes = [
  { path: '', redirectTo: '/form', pathMatch: 'full' },
  { path: 'form', component: FormLaunchComponent },
  { path: 'list', component: LaunchListComponent },
  { path: 'summary', component: DailySummaryComponent },
];
