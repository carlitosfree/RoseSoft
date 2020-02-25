import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {MAT_DIALOG_DATA, MatDialog, MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-modal-seleccionar-prostituta',
  templateUrl: './modal-seleccionar-prostituta.component.html',
  styleUrls: ['./modal-seleccionar-prospituta.component.scss']
})
export class ModalSeleccionarProstitutaComponent implements OnInit {
  prostituta: any = [];
  busquedaProstituta = '';
  filas = 5;
  url = 'http://localhost:1338';
  cantidad = 1;

  constructor(
    public dialogRef: MatDialogRef<ModalSeleccionarProstitutaComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public readonly _httpClient: HttpClient,
  ) { }

  ngOnInit(): void {
    const urlProstituta = this.url + '/prostituta';
    const prostituta$ = this._httpClient
      .get(urlProstituta);
    prostituta$
      .subscribe(
        (prostituta: any[]) => {
          console.log('Pokemones actuales en la base: ', prostituta);
          this.prostituta = prostituta;
        },
        (error) => {
          console.error({
            error : error,
            mensaje : 'Error consultando chongo',
          });
        }
      );
  }
  buscar() {
    let consulta = '';
    if (this.busquedaProstituta) {
      consulta = '?nombre=' + this.busquedaProstituta;
    }
    const urlBuscarProstituta = this.url + '/prostituta' + consulta;
    const prostitutasABuscar$ = this._httpClient
      .get(
        urlBuscarProstituta
      );
    prostitutasABuscar$
      .subscribe(
        (protistutasEncontrados) => {
          this.prostituta = protistutasEncontrados;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  cancelar() {
    this.dialogRef.close(); // cerrar la ventana del modal
  }
  enviar(protistuta) {
    this.dialogRef.close({
      nombre: protistuta.nombre,
      precio: protistuta.precio,
      idChongo: protistuta.idChongo.id,
      idProtistuta: protistuta.id,
      cantidad: this.cantidad,
      subtotal: this.cantidad * protistuta.precio
    });
  }
}
