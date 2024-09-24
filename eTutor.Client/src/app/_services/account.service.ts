import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private http = inject(HttpClient);

  baseUrl = "https://localhost:7055/api/";

  login(model: any) {
    return this.http.post(this.baseUrl + "Account/login", model);
  }

  register(model: any) {
    return this.http.post(this.baseUrl + "Account/register", model);
  }
}
