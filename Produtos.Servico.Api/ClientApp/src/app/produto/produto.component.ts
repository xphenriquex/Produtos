import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { ProdutoService } from '../services/produto.service';
import { Produto } from '../models/Produto';

@Component({
  selector: 'app-produto',
  templateUrl: './produto.component.html',
  styleUrls: ['./produto.component.css']
})
export class ProdutoComponent implements OnInit {
  produto$: Observable<Produto>;
  id: number;

  constructor(
    private produtoService: ProdutoService, 
    private avRoute: ActivatedRoute) {
    const idParam = 'id';
    if (this.avRoute.snapshot.params[idParam]) {
      this.id = this.avRoute.snapshot.params[idParam];
    }
  }

  ngOnInit() {
    this.loadProduto();
  }

  loadProduto() {
    var teste = this.produtoService.getProduto(this.id);
    console.log(teste)
    this.produto$ = this.produtoService.getProduto(this.id);
  }
}