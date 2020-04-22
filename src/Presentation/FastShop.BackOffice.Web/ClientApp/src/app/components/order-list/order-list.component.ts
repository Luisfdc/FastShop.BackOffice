import { Component, OnInit } from '@angular/core';
import { OrderService } from 'src/app/services/order.service';
import { Order } from '../../types/order';
import { ClientComponent } from '../client/client.component';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})
export class OrderListComponent implements OnInit {
  orders: Order[];
  private _orderService: OrderService;

  constructor(orderService: OrderService, private clientComponent: ClientComponent) {
    this._orderService = orderService;
   }

  ngOnInit(): void {
    this.clientComponent.event.subscribe(clientId => this.getOrdersClient(clientId));
  }

  getOrdersClient(clientId: number): void {
    this._orderService.getOrdersClient(clientId).subscribe(result => {
      this.orders = result;
    });
  }

}
