import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from '../material/material.module';
import { DialogComponent } from './dialog.component';


@NgModule({
  imports: [
    FormsModule,
    MaterialModule
  ],
  entryComponents: [DialogComponent],
  declarations: [DialogComponent]
})
export class DialogModule { }
