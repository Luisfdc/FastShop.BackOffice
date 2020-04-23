import { TestBed } from '@angular/core/testing';

import { OrderItemService } from './order-item.service';
import { HttpClient, HttpHandler } from '@angular/common/http';

describe('OrderItemService', () => {
  let service: OrderItemService;
  let handler: HttpHandler;
  let http: HttpClient;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = new HttpClient(handler);
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
