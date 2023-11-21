import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AtendimentosAgendadoComponent } from './atendimentos-agendado.component';

describe('AtendimentosAgendadoComponent', () => {
  let component: AtendimentosAgendadoComponent;
  let fixture: ComponentFixture<AtendimentosAgendadoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AtendimentosAgendadoComponent]
    });
    fixture = TestBed.createComponent(AtendimentosAgendadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
