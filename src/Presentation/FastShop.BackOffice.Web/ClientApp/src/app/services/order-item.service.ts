import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { OrderItem } from '../types/OrderItem';

@Injectable({
  providedIn: 'root'
})
export class OrderItemService {
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }


  getOrderItems(orderId: number) {
    return this.http.get<OrderItem[]>('/api/OrderItem/' + orderId);
  }
}
