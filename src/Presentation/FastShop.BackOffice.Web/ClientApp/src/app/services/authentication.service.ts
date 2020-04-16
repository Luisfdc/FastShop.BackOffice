import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private http: HttpClient;
  private nomeUsuario: string;

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }

  getUser() {
    return this.http.get<any>('/api/authentication/GetUser');
  }

}