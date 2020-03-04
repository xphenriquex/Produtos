import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProdutosComponent } from './produtos/produtos.component';
import { ProdutoComponent } from './produto/produto.component';
import { ProdutoAddEditComponent } from './produto-add-edit/produto-add-edit.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';

const routes: Routes = [
  { path: '', component: ProdutosComponent, pathMatch: 'full' },
  { path: 'produto/:id', component: ProdutoComponent },
  { path: 'add', component: ProdutoAddEditComponent },
  { path: 'produto/edit/:id', component: ProdutoAddEditComponent },
  { path: '**', redirectTo: '/' },
  { path: 'fetch-data', component: FetchDataComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }