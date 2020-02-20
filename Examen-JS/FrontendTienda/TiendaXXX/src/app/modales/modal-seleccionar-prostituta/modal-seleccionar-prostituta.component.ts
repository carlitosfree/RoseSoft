import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {MAT_DIALOG_DATA, MatDialog, MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-modal-seleccionar-prostituta',
  templateUrl: './modal-seleccionar-prostituta.component.html',
  styleUrls: ['./modal-seleccionar-prospituta.component.scss']
})
export class ModalSeleccionarProstitutaComponent implements OnInit {
  pokemones: any = [];
  busquedaPokemon = '';
  filas = 5;
  url = 'http://localhost:1338';
  cantidad = 1;

  constructor(
    public dialogRef: MatDialogRef<ModalSeleccionarProstitutaComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public readonly _httpClient: HttpClient,
  ) { }

  ngOnInit(): void {
    const urlPokemon = this.url + '/prostituta';
    const pokemon$ = this._httpClient
      .get(urlPokemon);
    pokemon$
      .subscribe(
        (pokemones: any[]) => {
          console.log('Pokemones actuales en la base: ', pokemones);
          this.pokemones = pokemones;
        },
        (error) => {
          console.error({
            error: error,
            mensaje: 'Error consultando chongo',
          });
        }
      );
  }
  buscar() {
    let consulta = '';
    if (this.busquedaPokemon) {
      consulta = '?nombre='+this.busquedaPokemon;
    }
    const urlBuscarPokemon = this.url + '/prostituta' + consulta;
    const pokemonesABuscar$ = this._httpClient
      .get(
        urlBuscarPokemon
      );
    pokemonesABuscar$
      .subscribe(
        (pokemonesEncontrados) => {
          this.pokemones = pokemonesEncontrados;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  cancelar() {
    this.dialogRef.close(); // cerrar la ventana del modal
  }
  enviar(pokemon) {
    this.dialogRef.close({
      nombre: pokemon.nombre,
      precio: pokemon.precio,
      idEntrenador: pokemon.idEntrenador.id,
      idPokemon: pokemon.id,
      cantidad: this.cantidad,
      subtotal: this.cantidad * pokemon.precio
    });
  }
}
