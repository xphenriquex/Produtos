
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { ProdutoService } from '../services/produto.service';
import { Produto } from '../models/Produto';

@Component({
  selector: 'app-produto-add-edit',
  templateUrl: './produto-add-edit.component.html',
  styleUrls: ['./produto-add-edit.component.css']
})
export class ProdutoAddEditComponent implements OnInit {

  form: FormGroup;
  actionType: string;
  formDescricao: string;
  formMarca: string;
  formNumeroLote: string;
  formPreco: string;
  id: number;
  errorMessage: any;
  existingProduto: Produto;

  constructor(
    private produtoService: ProdutoService, 
    private formBuilder: FormBuilder, 
    private avRoute: ActivatedRoute, 
    private router: Router) 
    {
      const idParam = 'id';
      this.actionType = 'Add';
      this.formDescricao = 'descricao';
      this.formMarca = 'marca';
      this.formNumeroLote = 'numeroLote';
      this.formPreco = 'preco';

      if (this.avRoute.snapshot.params[idParam]) {
        this.id = this.avRoute.snapshot.params[idParam];
      }

      this.form = this.formBuilder.group(
        {
          id: 0,
          descricao: ['', [Validators.required]],
          marca: ['', [Validators.required]],
          numeroLote: ['', [Validators.required]],
          preco: ['', [Validators.required]],
        }
      )
  }

  ngOnInit() {

    if (this.id > 0) {
      this.actionType = 'Edit';
      this.produtoService.getProduto(this.id)
        .subscribe(data => (
          this.existingProduto = data,
          this.form.controls[this.formDescricao].setValue(data.descricao),
          this.form.controls[this.formMarca].setValue(data.marca),
          this.form.controls[this.formNumeroLote].setValue(data.numeroLote),
          this.form.controls[this.formPreco].setValue(data.preco)
        ));
    }
  }

  save() {
    if (!this.form.valid) {
      return;
    }

    if (this.actionType === 'Add') {
      console.log("adddddddddddddddddddddd");
      let produto: Produto = {
        descricao: this.form.get(this.formDescricao).value,
        marca: this.form.get(this.formMarca).value,
        numeroLote: this.form.get(this.formNumeroLote).value,
        preco: this.form.get(this.formPreco).value,
      };

      this.produtoService.saveProduto(produto)
        .subscribe((data) => {
          this.router.navigate(['/produto', data.id]);
        });
    }

    if (this.actionType === 'Edit') {
      console.log("edittttttttttttttttt");
      let produto: Produto = {
        id: this.existingProduto.id,
        descricao: this.form.get(this.formDescricao).value,
        marca: this.form.get(this.formMarca).value,
        numeroLote: this.form.get(this.formNumeroLote).value,
        preco: this.form.get(this.formPreco).value,
      };

      this.produtoService.updateProduto(produto)
        .subscribe((data) => {
          this.router.navigate([this.router.url]);
        });
    }
  }

  cancel() {
    this.router.navigate(['/']);
  }

  get descricao() { return this.form.get(this.formDescricao); }
  get marca() { return this.form.get(this.formMarca); }
  get numeroLote() { return this.form.get(this.formNumeroLote); }
  get preco() { return this.form.get(this.formPreco); }
}
