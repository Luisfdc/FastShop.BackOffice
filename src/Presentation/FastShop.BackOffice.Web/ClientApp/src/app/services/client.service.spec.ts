import { TestBed } from '@angular/core/testing';
import { ClientService } from './client.service';
import { Client } from '../types/client';
import { Observable } from 'rxjs';

describe('ClientService', () => {


  let service: ClientService;
  let http: any;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = {
      get: jasmine.createSpy('get').and.returnValue(Observable.create(Client))
    };
    service = new ClientService(http);
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
