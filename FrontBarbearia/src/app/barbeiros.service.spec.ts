import { TestBed } from '@angular/core/testing';

import { BarbeirosService } from './barbeiros.service';

describe('BarbeirosService', () => {
  let service: BarbeirosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BarbeirosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
