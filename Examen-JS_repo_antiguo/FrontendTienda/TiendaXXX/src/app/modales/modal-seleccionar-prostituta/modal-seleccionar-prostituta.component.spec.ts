import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalSeleccionarProstitutaComponent } from './modal-seleccionar-prostituta.component';

describe('ModalSeleccionarProstitutaComponent', () => {
  let component: ModalSeleccionarProstitutaComponent;
  let fixture: ComponentFixture<ModalSeleccionarProstitutaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModalSeleccionarProstitutaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalSeleccionarProstitutaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
