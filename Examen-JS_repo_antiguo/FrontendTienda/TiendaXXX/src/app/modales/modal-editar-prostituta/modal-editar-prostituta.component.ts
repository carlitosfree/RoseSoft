import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-modal-editar-prostituta',
  templateUrl: './modal-editar-prostituta.component.html',
  styleUrls: ['./modal-editar-prostituta.component.scss']
})
export class ModalEditarProstitutaComponent implements OnInit {
numero = '';
nombre = '';
poderUno = '';
poderDos = '';
fechaCaptura = '';
nivel = '';
precio = '';
idEntrenador = '';
crear = false;


  constructor(
    public dialogRef: MatDialogRef<ModalEditarProstitutaComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) { }

  ngOnInit() {
    console.log('datos que han llegado al modal: ', this.data);
    if (this.data.prostituta !== undefined) {
      this.numero = this.data.prostituta.numero;
      this.nombre = this.data.prostituta.nombre;
      this.poderUno = this.data.prostituta.poderUno;
      this.poderDos = this.data.prostituta.poderDos;
      this.fechaCaptura = this.data.prostituta.fechaCaptura;
      this.nivel = this.data.prostituta.nivel;
      this.precio = this.data.prostituta.precio;
      this.idEntrenador = this.data.prostituta.idEntrenador.id;
    } else {
     this.crear = true;
     this.idEntrenador = this.data;
    }
  }
  cancelar() {
    this.dialogRef.close(); // cerrar la ventana del modal
  }

  aceptar() {
    this.dialogRef.close({
      numero: this.numero,
      nombre: this.nombre,
      poderUno: this.poderUno,
      poderDos: this.poderDos,
      fechaCaptura: this.fechaCaptura,
      nivel: this.nivel,
      precio: this.precio,
      idEntrenador: this.idEntrenador
    });
  }

}
