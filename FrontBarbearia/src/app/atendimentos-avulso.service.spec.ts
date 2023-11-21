import { TestBed } from '@angular/core/testing';

import { AtendimentosAvulsoService } from './atendimentos-avulso.service';

describe('AtendimentosAvulsoService', () => {
  let service: AtendimentosAvulsoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AtendimentosAvulsoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
