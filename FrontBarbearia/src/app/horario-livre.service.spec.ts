import { TestBed } from '@angular/core/testing';

import { HorarioLivreService } from './horario-livre.service';

describe('HorarioLivreService', () => {
  let service: HorarioLivreService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HorarioLivreService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
