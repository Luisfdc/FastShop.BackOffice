import { TestBed } from '@angular/core/testing';

import { OrderService } from './order.service';
import { HttpClient, HttpHandler } from '@angular/common/http';
import { Order } from '../types/order';

describe('OrderService', () => {
  let service: OrderService;
  let handler: HttpHandler;
  let http: HttpClient;
  let order: Order;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = new HttpClient(handler);
    service = new OrderService(http);
    order = new Order();
    order.id = 1;
    order.status = 1;
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('test getOrdersClient', () => {
    service.getOrdersClient(1).subscribe(result => {
      expect(result).not.toBeNull();
    });
  });

  it('test getOrder', () => {
    service.getOrder(1).subscribe(result => {
      expect(result).not.toBeNull();
    });
  });

  it('test updateStatus', () => {
    service.updateStatus(order).subscribe(result => {
      expect(result).toEqual(1);
    });
  });
});
