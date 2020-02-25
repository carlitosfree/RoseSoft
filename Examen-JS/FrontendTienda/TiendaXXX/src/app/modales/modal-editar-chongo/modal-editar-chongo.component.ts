import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-modal-editar-chongo',
  templateUrl: './modal-editar-chongo.component.html',
  styleUrls: ['./modal-editar-chongo.component.scss']
})
export class ModalEditarChongoComponent implements OnInit {
  nombreChongoris = '';
  direccion = '';
  fechaApertura = '';
  numeroEstrellas = '';
  horarioApertura = '';
  crear = false;
  constructor(
    public dialogRef: MatDialogRef<ModalEditarChongoComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) { }
  ngOnInit(): void {
    console.log('datos en modal: ', this.data);
    if (this.data) {
      this.nombreChongoris = this.data.chongo.nombreChongoris;
      this.direccion = this.data.chongo.direccion;
      this.fechaApertura = this.data.chongo.fechaApertura;
      this.numeroEstrellas = this.data.chongo.numeroEstrellas;
      this.horarioApertura = this.data.chongo.horarioApertura;
    } else {
      this.crear = true;
    }
  }
  cancelar() {
    this.dialogRef.close(); // cerrar la ventana del modal
  }

  aceptar() {
    this.dialogRef.close({
      nombreChongoris: this.nombreChongoris,
      direccion: this.direccion,
      fechaApertura: this.fechaApertura,
      numeroEstrellas: this.numeroEstrellas,
      horarioApertura: this.horarioApertura,
    });
  }

}
