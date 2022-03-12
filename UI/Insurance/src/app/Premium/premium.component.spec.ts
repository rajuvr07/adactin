import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { PremiumComponent } from './premium.component';

describe('PremiumComponent', () => {
  let component: PremiumComponent;
  let fixture: ComponentFixture<PremiumComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ PremiumComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PremiumComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
