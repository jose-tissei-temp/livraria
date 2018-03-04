import { Component, OnInit } from '@angular/core';
import { LivroViewModel } from '../tabela/tabela.component';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { LivrosService } from './../livros.service';
import { FormularioComponent } from './formulario.component';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioEdicaoComponent extends FormularioComponent implements OnInit {

  constructor(router: Router, service: LivrosService, private route: ActivatedRoute) {
    super(router, service);
   }

  ngOnInit() {
    this.route.params.subscribe(this.carregarModel);
  }

  carregarModel = (params: Params) => {
    const id = params['id'];

    if (!id) { return; }

    this.service.obterLivro(id).subscribe(livro => this.model = livro);
  }

}
