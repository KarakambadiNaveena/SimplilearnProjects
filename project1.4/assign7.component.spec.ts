import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Assign7Component } from './assign7.component';

describe('Assign7Component', () => {
  let component: Assign7Component;
  let fixture: ComponentFixture<Assign7Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Assign7Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Assign7Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
