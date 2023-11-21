import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AtendimentosAvulsoComponent } from './atendimentos-avulso.component';

describe('AtendimentosAvulsoComponent', () => {
  let component: AtendimentosAvulsoComponent;
  let fixture: ComponentFixture<AtendimentosAvulsoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AtendimentosAvulsoComponent]
    });
    fixture = TestBed.createComponent(AtendimentosAvulsoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
