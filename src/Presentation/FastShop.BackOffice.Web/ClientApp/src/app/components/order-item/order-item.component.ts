import { Component, OnInit } from '@angular/core';
import { OrderComponent } from '../order/order.component';
import { OrderItemService } from '../../services/order-item.service';
import { OrderItem } from '../../types/OrderItem';

@Component({
  selector: 'app-order-item',
  templateUrl: './order-item.component.html',
  styleUrls: ['./order-item.component.css']
})
export class OrderItemComponent implements OnInit {
  orderItems: OrderItem[];

  constructor(private orderComponent: OrderComponent, private orderItemService: OrderItemService) { }

  ngOnInit(): void {
    this.orderComponent.event.subscribe(orderId => this.getOrderItems(orderId));
  }
  getOrderItems(orderId: number) {
    this.orderItemService.getOrderItems(orderId).subscribe(result => this.orderItems = result);
    }

}
