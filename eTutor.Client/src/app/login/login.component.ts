import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { AccountService } from '../_services/account.service';
import { BehaviorSubject } from "rxjs";

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  private _accountService = inject(AccountService);
  error$ = new BehaviorSubject('');
  model: any = {};
  loggedIn = false;

  login() {
    console.log(this.model);
    this._accountService.login(this.model).subscribe({
      next: response => {
        console.log(response);
      },
      error: error => {
        debugger;
        console.log(error);
        this.error$.next(error?.error || 'Unknown Error')
      }
    })
  }
}
