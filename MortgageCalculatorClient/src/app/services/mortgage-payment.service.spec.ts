import { TestBed } from '@angular/core/testing';

import { MortgagePaymentService } from './mortgage-payment.service';

describe('MortgagePaymentService', () => {
  let service: MortgagePaymentService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MortgagePaymentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
