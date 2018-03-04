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
import { LivrosModule } from './livros/livros.module';
import { DialogModule } from './dialog/dialog.module';
import { FormularioEdicaoComponent } from './livros/formulario/formulario-edicao.component';

const APP_ROUTES: Routes = [
  { path: '', component: TabelaComponent },
  { path: 'livros', component: TabelaComponent },
  { path: 'livros/:id', component: FormularioEdicaoComponent },
  { path: 'novo-livro', component: FormularioComponent },
];

@NgModule({
  imports: [
    BrowserModule,
    MaterialModule,
    LivrosModule,
    DialogModule,
    RouterModule.forRoot(
      APP_ROUTES,
      { enableTracing: environment.production ? false : true  }
    )
  ],
  entryComponents: [AppComponent],
  declarations: [AppComponent],
  bootstrap: [AppComponent],
  providers: []
})
export class AppModule { }

