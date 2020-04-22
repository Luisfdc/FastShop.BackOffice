import { Component, OnInit, EventEmitter } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { OrderService } from '../../services/order.service';
import { Order } from '../../types/order';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
  orderId: number;
  order: Order;
  event = new EventEmitter<number>();
  param: number;

  constructor(private orderService: OrderService, private route: ActivatedRoute ) {
    this.route.params.subscribe(params => {
      this.param = params['id'];
      this.orderId = this.param;
    });

    if (this.orderId != null)
      this.getOrder();
  }

  ngOnInit(): void {
  }


  getOrder(): void {
    this.orderService.getOrder(this.orderId).subscribe(result => {
      this.order = result;
      this.event.emit(this.orderId);
    });
  }

  updateStatus(statusId: number): void {
    this.order.status = statusId;
    this.orderService.updateStatus(this.order).subscribe(result => {
      alert("Status atualizado");
    });
  }

}
