import {Component, OnInit, OnDestroy} from '@angular/core';
import {MatTableDataSource} from '@angular/material';
import { LivrosService } from '../livros.service';
import { Subscription } from 'rxjs/Subscription';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { DialogComponent, DialogData } from '../../dialog/dialog.component';

@Component({
  selector: 'app-livros-tabela',
  styleUrls: ['tabela.component.css'],
  templateUrl: 'tabela.component.html',
})
export class TabelaComponent implements OnInit {
  displayedColumns = ['titulo', 'autor', 'estoque', 'acoes'];
  livros: MatTableDataSource<LivroViewModel>;

  constructor(private service: LivrosService, public dialog: MatDialog) {  }

  ngOnInit(): void {
    this.livros = new MatTableDataSource(new Array<LivroViewModel>());
    this.carregarLivros();
  }

  filtrar(valor: string) {
    valor = valor.trim();
    valor = valor.toLowerCase();
    this.livros.filter = valor;
  }

  carregarLivros() {
    this.service.obterLivros().subscribe(valores => this.livros = new MatTableDataSource(valores));
  }

  openDialog(livro: LivroViewModel) {
    const dialogRef = this.dialog.open(DialogComponent, {
      width: '500px',
      height: '225px',
      data: new DialogData(livro.id, 'Deseja excluir o livro?', livro.titulo)
    });

    dialogRef.afterClosed().subscribe(result => {
      this.service.remover(result).subscribe(response => this.carregarLivros());
    });
  }
}

export class LivroViewModel {
  id: string;
  titulo: string;
  autor: string;
  estoque: number;
}
