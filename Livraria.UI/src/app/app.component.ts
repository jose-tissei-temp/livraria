import { Component, OnInit, OnDestroy } from '@angular/core';
import { LivrosService } from './livros/livros.service';
import { Subscription } from 'rxjs/Subscription';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  livros: string[];
  subscription: Subscription;
  constructor(private service: LivrosService) {
    this.livros = [];
  }

  ngOnInit() {
    this.subscription = this.service.obterLivros().subscribe(valores => this.livros = valores);
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
}
