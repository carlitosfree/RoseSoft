import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProstitutaComponent } from './prostituta.component';

describe('ProstitutaComponent', () => {
  let component: ProstitutaComponent;
  let fixture: ComponentFixture<ProstitutaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProstitutaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProstitutaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
