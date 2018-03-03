import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { LivrosService } from './livros/livros.service';
import { AppComponent } from './app.component';
import { HttpModule } from '@angular/http';
import { MaterialModule } from './material/material.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LivrosComponent } from './livros/livros.component';
import { MatTable, MatHeaderCell, MatCell, MatHeaderRow, MatRow, MatHeaderRowDef, MatRowDef, MatInputModule } from '@angular/material';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

@NgModule({
  declarations: [
    AppComponent,
    LivrosComponent,
    MatTable,
    MatHeaderCell,
    MatCell,
    MatHeaderRow,
    MatRow,
    MatHeaderRowDef,
    MatRowDef
  ],
  imports: [
    BrowserModule,
    HttpModule,
    MaterialModule,
    MatInputModule,
    BrowserAnimationsModule
  ],
  providers: [
    LivrosService
  ],
  entryComponents: [AppComponent],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }

platformBrowserDynamic().bootstrapModule(AppModule);
