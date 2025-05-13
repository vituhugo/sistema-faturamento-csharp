import { Component } from '@angular/core';
import {RouterLink, RouterOutlet} from '@angular/router';
import {bootstrapApplication} from '@angular/platform-browser';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  imports: [
    RouterOutlet,
    RouterLink
  ]
})
export class AppComponent {}
