import { Component, OnInit, OnDestroy, ViewContainerRef } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
import { Subscription } from 'rxjs/Subscription';
import { LivrosService } from './livros.service';

@Component({
  selector: 'app-livros',
  templateUrl: './livros.component.html',
  styleUrls: ['./livros.component.css']
})
export class LivrosComponent implements OnInit, OnDestroy {

  colunasExibidas: string[];
  livros: MatTableDataSource<ViewModels.LivroViewModel>;
  subscription: Subscription;

  constructor(private service: LivrosService) {
    this.colunasExibidas = ['id', 'titulo'];
    this.livros = new MatTableDataSource(ELEMENT_DATA);
  }

  filtrar(valor: string) {
    valor = valor.trim();
    valor = valor.toLowerCase();
    this.livros.filter = valor;
  }

  ngOnInit() {
    // this.subscription = this.service.obterLivros().subscribe(valores => this.livros = new MatTableDataSource(valores));
  }

  ngOnDestroy(): void {
    // this.subscription.unsubscribe();
  }
}
const ELEMENT_DATA: ViewModels.LivroViewModel[] = [
  {id: '123', titulo: 'Teste'}
];
