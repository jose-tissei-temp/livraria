import { Component, OnInit } from '@angular/core';
import { LivroViewModel } from '../tabela/tabela.component';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { LivrosService } from './../livros.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent {
  model: LivroViewModel;

  constructor(protected router: Router, protected service: LivrosService) {
    this.model = new LivroViewModel();
  }

  onSubmit() {
    this.service.salvar(this.model).subscribe(response => this.router.navigate(['../livros']));
  }
}
