import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule, provideHttpClient} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { FormLaunchComponent } from './components/form-launch/form-launch.component';
import { LaunchListComponent } from './components/launch-list/launch-list.component';
import { DailySummaryComponent } from './components/daily-summary/daily-summary.component';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    FormLaunchComponent,
    LaunchListComponent,
    DailySummaryComponent,
    BrowserModule,
    FormsModule,
  ],
  providers: [
    provideHttpClient(),
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
