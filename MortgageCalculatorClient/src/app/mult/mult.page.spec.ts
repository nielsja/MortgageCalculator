import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { MultPage } from './mult.page';

describe('MultPage', () => {
  let component: MultPage;
  let fixture: ComponentFixture<MultPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MultPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(MultPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
