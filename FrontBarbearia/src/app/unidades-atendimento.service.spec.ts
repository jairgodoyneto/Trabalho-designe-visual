import { TestBed } from '@angular/core/testing';

import { UnidadesAtendimentoService } from './unidades-atendimento.service';

describe('UnidadesAtendimentoService', () => {
  let service: UnidadesAtendimentoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UnidadesAtendimentoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
