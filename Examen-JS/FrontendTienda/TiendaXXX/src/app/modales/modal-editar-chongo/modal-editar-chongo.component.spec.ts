import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalEditarChongoComponent } from './modal-editar-chongo.component';

describe('ModalEditarChongoComponent', () => {
  let component: ModalEditarChongoComponent;
  let fixture: ComponentFixture<ModalEditarChongoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModalEditarChongoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalEditarChongoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
