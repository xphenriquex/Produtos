import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Produto } from '../models/Produto';

@Injectable({
  providedIn: 'root'
})
export class ProdutoService {

  myAppUrl: string;
  myApiUrl: string;

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json; charset=utf-8'
    })
  };
  
  constructor(private http: HttpClient) {
      this.myAppUrl = environment.appUrl;
      this.myApiUrl = 'api/Produtos/';
  }

  getProdutos(): Observable<Produto[]> {
    return this.http.get<Produto[]>(this.myAppUrl + "/" + this.myApiUrl)
    .pipe(
      retry(1),
      catchError(this.errorHandler)
    );
  }

  getProduto(id: number): Observable<Produto> {
      return this.http.get<Produto>(this.myAppUrl + "/" + this.myApiUrl + id)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  saveProduto(produto: Produto): Observable<Produto> {
      return this.http.post<Produto>(this.myAppUrl + "/" + this.myApiUrl, JSON.stringify(produto), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  updateProduto(produto: Produto): Observable<Produto> {
      console.log(this.myAppUrl + "/" + this.myApiUrl, JSON.stringify(produto));
      return this.http.put<Produto>(this.myAppUrl + "/" + this.myApiUrl, JSON.stringify(produto), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  deleteProduto(id: number): Observable<Produto> {
      return this.http.delete<Produto>(this.myAppUrl + "/" + this.myApiUrl + id)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  errorHandler(error: { error: { message: string; }; status: any; message: any; }) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
}