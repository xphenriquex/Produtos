import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutoAddEditComponent } from './produto-add-edit.component';

describe('ProdutoAddEditComponent', () => {
  let component: ProdutoAddEditComponent;
  let fixture: ComponentFixture<ProdutoAddEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProdutoAddEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProdutoAddEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
