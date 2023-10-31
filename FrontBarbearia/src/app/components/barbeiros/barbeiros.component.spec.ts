import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BarbeirosComponent } from './barbeiros.component';

describe('BarbeirosComponent', () => {
  let component: BarbeirosComponent;
  let fixture: ComponentFixture<BarbeirosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BarbeirosComponent]
    });
    fixture = TestBed.createComponent(BarbeirosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
