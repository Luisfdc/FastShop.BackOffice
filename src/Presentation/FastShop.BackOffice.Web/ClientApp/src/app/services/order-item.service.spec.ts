import { TestBed } from '@angular/core/testing';

import { OrderItemService } from './order-item.service';
import { Observable } from 'rxjs';
import { OrderItem } from '../types/OrderItem';

describe('OrderItemService', () => {
  let service: OrderItemService;
  let http: any;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = {
      get: jasmine.createSpy('get').and.returnValue(Observable.create(OrderItem))
    };
    service = new OrderItemService(http)
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });


  it('test getOrderItems', () => {
    service.getOrderItems(1).subscribe(result => {
      expect(result).not.toBeNull();
    });
  });
});
