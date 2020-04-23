import { TestBed } from '@angular/core/testing';

import { AuthenticationService } from './authentication.service';
import { HttpClient, HttpHandler } from '@angular/common/http';

describe('AuthenticationService', () => {
  let service: AuthenticationService;
  let handler: HttpHandler;
  let http: HttpClient;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = new HttpClient(handler);
    service = new AuthenticationService(http)
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });


  it('test getUser', () => {
    service.getUser().subscribe(result => {
      expect(result).not.toBeNull();
    });
  });

});
