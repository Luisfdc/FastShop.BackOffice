import { TestBed } from '@angular/core/testing';

import { OrderService } from './order.service';
import { Order } from '../types/order';
import { Observable } from 'rxjs';

describe('OrderService', () => {
  let service: OrderService;
  let http: any;
  let order: Order;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    order = new Order();
    order.id = 1;
    order.status = 1;

    http = {
      get: jasmine.createSpy('get').and.returnValue(Observable.create(Order)),
      post: jasmine.createSpy('post').and.returnValue(Observable.create(1))
    };
    service = new OrderService(http);
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
