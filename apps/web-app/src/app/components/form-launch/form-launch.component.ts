import { Component } from '@angular/core';
import { LaunchService, Launch } from '../../services/launch.service';
import {FormsModule} from '@angular/forms';
import {NgIf} from '@angular/common';

@Component({
  selector: 'app-form-launch',
  templateUrl: './form-launch.component.html',
  imports: [
    FormsModule,
    NgIf
  ],
  styleUrls: ['./form-launch.component.css']
})
export class FormLaunchComponent {
  launch: Launch = { amount: 0, description: '', type: 'credit', date: new Date().toISOString().substr(0,19) };
  message = '';

  constructor(private service: LaunchService) {}

  submit() {
    this.service.create(this.launch).subscribe(() => {
      this.message = 'Lançamento registrado com sucesso!';
      this.launch = { amount: 0, description: '', type: 'credit', date: new Date().toISOString().substr(0,19) };
    }, () => this.message = 'Erro ao registrar lançamento.');
  }
}
