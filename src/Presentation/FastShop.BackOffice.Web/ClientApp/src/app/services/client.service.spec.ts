import { TestBed } from '@angular/core/testing';

import { ClientService } from './client.service';
import { HttpClient, HttpHandler } from '@angular/common/http';

describe('ClientService', () => {


  let service: ClientService;
  let handler: HttpHandler;
  let http: HttpClient;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = new HttpClient(handler);
    service = new ClientService(http)
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });


  it('Validar busca de cliente', () => {
    service.getClient('39681706013').subscribe(result => {
      expect(result).not.toBeNull();
    });
  });
});
