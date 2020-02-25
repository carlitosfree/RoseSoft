import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-modal-editar-chongo',
  templateUrl: './modal-editar-chongo.component.html',
  styleUrls: ['./modal-editar-chongo.component.scss']
})
export class ModalEditarChongoComponent implements OnInit {
  nombre = '';
  apellido = '';
  fechaNacimiento = '';
  numeroMedalla = '';
  campeonActual = '';
  crear = false;
  constructor(
    public dialogRef: MatDialogRef<ModalEditarChongoComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) { }
  ngOnInit(): void {
    console.log('datos en modal: ', this.data);
    if (this.data) {
      this.nombre = this.data.chongo.nombre;
      this.apellido = this.data.chongo.apellido;
      this.fechaNacimiento = this.data.chongo.fechaNacimiento;
      this.numeroMedalla = this.data.chongo.numeroMedalla;
      this.campeonActual = this.data.chongo.campeonActual;
    } else {
      this.crear = true;
    }
  }
  cancelar() {
    this.dialogRef.close(); // cerrar la ventana del modal
  }

  aceptar() {
    this.dialogRef.close({
      nombre: this.nombre,
      apellido: this.apellido,
      fechaNacimiento: this.fechaNacimiento,
      numeroMedalla: this.numeroMedalla,
      campeonActual: this.campeonActual,
    });
  }

}
