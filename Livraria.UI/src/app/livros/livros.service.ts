import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, RequestOptionsArgs, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { environment } from './../../environments/environment';
import { LivroViewModel } from './tabela/tabela.component';
import 'rxjs/add/operator/map';

export const URL_LIVROS = `${environment.apiUrl}/livros`;

@Injectable()
export class LivrosService {
  constructor(private http: Http) {
  }

  obterLivros(): Observable<LivroViewModel[]> {
    return this.http.get(URL_LIVROS).map(response => response.json());
  }

  obterLivro(id: string): Observable<LivroViewModel> {
    return this.http.get(`${URL_LIVROS}/${id}`).map(response => response.json());
  }

  salvar(livro: LivroViewModel): Observable<Response> {
    if (livro.id) {
      return this.http.put(URL_LIVROS, livro);
    }

    return this.http.post(URL_LIVROS, livro);
  }

  remover(id: string): Observable<Response> {
    return this.http.delete(`${URL_LIVROS}/${id}`);
  }
}
