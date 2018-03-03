import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  livros: string[];
  constructor() {
    this.livros = [
      "Harry Potter e a Pedra Filosofal",
      "O Hobbit"
    ];
  }
}
