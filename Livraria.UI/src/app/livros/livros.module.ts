import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { MaterialModule } from '../material/material.module';
import { MatNativeDateModule } from '@angular/material';
import { TabelaComponent } from './tabela/tabela.component';
import { FormularioComponent } from './formulario/formulario.component';
import { LivrosService } from './livros.service';
import { RouterModule } from '@angular/router';
import { environment } from '../../environments/environment';
import { DialogModule } from '../dialog/dialog.module';
import { FormularioEdicaoComponent } from './formulario/formulario-edicao.component';

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
    RouterModule,
    DialogModule
  ],
  declarations: [TabelaComponent, FormularioComponent, FormularioEdicaoComponent],
  bootstrap: [],
  providers: [LivrosService]
})
export class LivrosModule { }
