import { TestBed } from '@angular/core/testing';

import { AuthenticationService } from './authentication.service';
import { Observable } from 'rxjs';

describe('AuthenticationService', () => {
  let service: AuthenticationService;
  let http: any;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    http = {
      get: jasmine.createSpy('get').and.returnValue(Observable.create({name: "User"}))
    };
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
