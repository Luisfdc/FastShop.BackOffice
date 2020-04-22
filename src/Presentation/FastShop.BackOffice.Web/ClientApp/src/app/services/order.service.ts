import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../types/order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }


  getOrdersClient(clientId: number) {
    return this.http.get<Order[]>('/api/Order/' + clientId + '/Client');
  }

  getOrder(orderId: number) {
    return this.http.get<Order>('/api/Order/' + orderId);
  }

  updateStatus(order: Order) {
    return this.http.post<any>('/api/Order/UpdateStatus/', order);
  }
}
