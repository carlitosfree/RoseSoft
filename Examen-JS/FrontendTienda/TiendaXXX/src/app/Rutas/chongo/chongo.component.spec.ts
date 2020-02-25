import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChongoComponent } from './chongo.component';

describe('EntrenadorComponent', () => {
  let component: ChongoComponent;
  let fixture: ComponentFixture<ChongoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChongoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChongoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
