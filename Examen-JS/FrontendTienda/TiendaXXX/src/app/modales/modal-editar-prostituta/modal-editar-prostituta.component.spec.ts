import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalEditarProstitutaComponent } from './modal-editar-prostituta.component';

describe('ModalEditarProstitutaComponent', () => {
  let component: ModalEditarProstitutaComponent;
  let fixture: ComponentFixture<ModalEditarProstitutaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModalEditarProstitutaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalEditarProstitutaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
