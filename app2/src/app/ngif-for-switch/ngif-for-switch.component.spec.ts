import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NgifForSwitchComponent } from './ngif-for-switch.component';

describe('NgifForSwitchComponent', () => {
  let component: NgifForSwitchComponent;
  let fixture: ComponentFixture<NgifForSwitchComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NgifForSwitchComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NgifForSwitchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
