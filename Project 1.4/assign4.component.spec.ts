import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Assign4Component } from './assign4.component';

describe('Assign4Component', () => {
  let component: Assign4Component;
  let fixture: ComponentFixture<Assign4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Assign4Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Assign4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
