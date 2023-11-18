import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UnidadesAtendimentoComponent } from './unidades-atendimento.component';

describe('UnidadesAtendimentoComponent', () => {
  let component: UnidadesAtendimentoComponent;
  let fixture: ComponentFixture<UnidadesAtendimentoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UnidadesAtendimentoComponent]
    });
    fixture = TestBed.createComponent(UnidadesAtendimentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
