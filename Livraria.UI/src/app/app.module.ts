import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HttpModule } from '@angular/http';
import { MaterialModule } from './material/material.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatNativeDateModule } from '@angular/material';
import { TabelaComponent } from './livros/tabela/tabela.component';
import { LivrosService } from './livros/livros.service';
import { FormularioComponent } from './livros/formulario/formulario.component';
import { environment } from '../environments/environment';
import { DialogComponent } from './livros/tabela/dialog.component';

const appRoutes: Routes = [
  { path: '', component: TabelaComponent },
  { path: 'livros', component: TabelaComponent },
  { path: 'livros/:id', component: FormularioComponent },
  { path: 'livros/novo', component: FormularioComponent },
];

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpModule,
    HttpClientModule,
    MaterialModule,
    MatNativeDateModule,
    ReactiveFormsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: environment.production ? false : true  }
    )
  ],
  entryComponents: [AppComponent, DialogComponent],
  declarations: [AppComponent, TabelaComponent, FormularioComponent, DialogComponent],
  bootstrap: [AppComponent],
  providers: [LivrosService]
})
export class AppModule { }

