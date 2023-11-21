import { TestBed } from '@angular/core/testing';

import { AtendimentosAgendadoService } from './atendimentos-agendado.service';

describe('AtendimentosAgendadoService', () => {
  let service: AtendimentosAgendadoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AtendimentosAgendadoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
