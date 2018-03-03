import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { environment } from './../../environments/environment';
import 'rxjs/add/operator/map';

@Injectable()
export class LivrosService {
  private static readonly UrlLivros = `${environment.apiUrl}/livros`;

  constructor(private http: Http) {
  }

  obterLivros(): Observable<string[]> {
    return this.http.get(LivrosService.UrlLivros).map((response: Response) => response.json());
  }
}
