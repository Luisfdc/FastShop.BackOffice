import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Client } from '../types/client';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }


  getClient(document: string) {
    return this.http.get<Client>('/api/Client/' + document);
  }
}
