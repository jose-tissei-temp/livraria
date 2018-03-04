import { Component, OnInit } from '@angular/core';
import { LivroViewModel } from '../tabela/tabela.component';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { LivrosService } from './../livros.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent implements OnInit {

  model: LivroViewModel;

  constructor(private router: Router, private service: LivrosService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.model = new LivroViewModel();
    this.route.params.subscribe(this.carregarModel);
  }

  onSubmit() {
    this.service.salvar(this.model).subscribe(response => this.router.navigate(['../livros']));
  }

  carregarModel = (params: Params) => {
    const id = params['id'];

    if (!id || id === 'novo') { return; }

    this.service.obterLivro(id).subscribe(livro => this.model = livro);
  }

}
