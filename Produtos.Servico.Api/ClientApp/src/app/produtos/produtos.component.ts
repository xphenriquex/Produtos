import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ProdutoService } from '../services/produto.service';
import { Produto } from '../models/Produto';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.css']
})
export class ProdutosComponent implements OnInit {
  produtos$: Observable<Produto[]>;

  constructor(private produtoService: ProdutoService) { }

  ngOnInit(): void {
    this.loadProdutos();
  }

  loadProdutos() {
    this.produtos$ = this.produtoService.getProdutos();
  }

  delete(id) {
    const ans = confirm('Do you want to delete blog post with id: ' + id);
    if (ans) {
      this.produtoService.deleteProduto(id).subscribe((data) => {
        this.loadProdutos();
      });
    }
  }

}
