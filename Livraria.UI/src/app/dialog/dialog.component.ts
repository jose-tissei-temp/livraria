import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-dialog',
  templateUrl: 'dialog.component.html',
})
export class DialogComponent {

  constructor(
    public dialogRef: MatDialogRef<DialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}

export class DialogData {
  id: string;
  titulo: string;
  mensagem: string;

  constructor(id: string, titulo: string, mensagem: string) {
    this.id = id;
    this.titulo = titulo;
    this.mensagem = mensagem;
  }
}
