import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {MatDialog} from '@angular/material/dialog';
import {ProstitutaRestService} from '../../Services/prostituta-rest.service';
import {ModalEditarProstitutaComponent} from '../../modales/modal-editar-prostituta/modal-editar-prostituta.component';
import {ActivatedRoute, Router} from "@angular/router";


@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.scss']
})
export class PokemonComponent implements OnInit {
  pokemones = [];
  idEntrenador: number;
  numeroFiltrado: number;
  nombreFiltrado = '';
  poderUnoFiltrado = '';
  poderDosFiltrado = '';
  fechacapturaFiltrado = '';
  nivelFiltrado: number;
  precioFiltrado: number;
  filas = 3;
  busquedaPokemon = '';
  url = 'http://localhost:1338';
  constructor(
    private readonly _httpClient: HttpClient,
    public readonly _matDialog: MatDialog,
    private readonly _pokemorestService: ProstitutaRestService,
    private readonly _activatedRoute: ActivatedRoute,
    private readonly _router: Router,
  ) {
  }

  ngOnInit() {
    this.escucharParametros();
    /*const urlPokemon = this.url + '/prostituta';
    const prostituta$ = this._httpClient.get(urlPokemon);
    prostituta$
      .subscribe(
        (pokemones: any[]) => {
          this.pokemones = pokemones;
        },
        (error) => {
          console.error({
            error: error,
            mensaje: 'Error consultando prostituta'
          });
        }
      );*/
  }
  escucharParametros() {
    const parametrosEntrenador$ = this._activatedRoute.params;
    parametrosEntrenador$
      .subscribe(
        (parametros: { idEntrenador: string }) => {
          this.idEntrenador = +parametros.idEntrenador;
          this.buscarPokemonPorEntrenador(+parametros.idEntrenador);
        }
      );
  }
  buscarPokemonPorEntrenador(idEntrenador: number) {
    const consulta = `idEntrenador=${idEntrenador}`;
    const pokemones$ = this._pokemorestService
      .buscarPorEntrenador(consulta, this.busquedaPokemon);
    pokemones$
      .subscribe(
        (pokemones) => { // OK
          this.pokemones = pokemones;
        },
        (error) => {  // ERROR
          console.error(error);
        }
      );
  }
  buscar() {
    const busqueda$ = this._pokemorestService
      .buscar(this.busquedaPokemon);
    busqueda$
      .subscribe(
        (pokemones) => {
          this.pokemones = pokemones;
        },
        (error) => {
          console.error(error);
        }
      );
  }
  ingresar() {
    const matDialogRefModalIngresarUsuario =  this._matDialog
      .open(
        ModalEditarProstitutaComponent,
        {width: '500px', data: this.idEntrenador
        }
      );
    const respuestaDialog$ = matDialogRefModalIngresarUsuario
      .afterClosed();
    respuestaDialog$
      .subscribe(
        (datos) => {
          if (datos) {
            this.ingresarPokemonHttp(datos);
          } else {
            // undefined
          }
        },
        () => {}
      );
  }
  ingresarPokemonHttp(datos) {
    const pokemonIngresadoS = this._pokemorestService
      .ingresar(datos);
    pokemonIngresadoS
      .subscribe(
        (pokemonIngresado) => {
          this.pokemones.push(pokemonIngresado);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  editar(pokemon) {
    console.log('Empieza el metodo editar con estos datos: ', pokemon);
    const matDialogRefModalEditarPokemon = this._matDialog
      .open(
        ModalEditarProstitutaComponent,
        {width: '500px', data: {prostituta: pokemon}}
      );
    const  respuestaDialogo$ = matDialogRefModalEditarPokemon
      .afterClosed();
    respuestaDialogo$
      .subscribe(
        (datos) => { // try
          console.log('Esta es la respuesta del Dialogo: ', datos);
          if (datos) {
            this.editarPokemonHttp(pokemon.id, datos);
          } else {
            // undefined
          }
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  editarPokemonHttp(id: number, datos) {
    const usuarioEditado$ = this._pokemorestService
      .editar(id, datos);
    usuarioEditado$
      .subscribe(
        (pokemonEditado: any) => {
          console.log('Usuario editado: ', pokemonEditado);
          const indice = this.pokemones
            .findIndex(
              (pokemon) => {
                return pokemon.id === id;
              }
            );
          this.pokemones[indice].numero = datos.numero;
          this.pokemones[indice].nombre = datos.nombre;
          this.pokemones[indice].poderUno = datos.poderUno;
          this.pokemones[indice].poderDos = datos.poderDos;
          this.pokemones[indice].fechaCaptura = datos.fechaCaptura;
          this.pokemones[indice].nivel = datos.nivel;
          this.pokemones[indice].precio = datos.precio;
          this.pokemones[indice].idEntrenador.id = datos.idEntrenador;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  eliminar(pokemon) {
    const eliminar$ = this._pokemorestService
      .eliminar(pokemon.id);
    eliminar$
      .subscribe(
        (pokemonEliminado) => {
          const indice = this.pokemones
            .findIndex(
              (pokemonBuscado) => {
                return pokemonBuscado.id === pokemonEliminado.id;
              }
            );
          this.pokemones.splice(indice, 1);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  volver() {
    this._router.navigate(['/chongo']);
  }

  pokemonesFiltrados() {
    return this.pokemones
      .filter(
        (pokemon) => {
          return pokemon.nombre.toLowerCase().includes(this.nombreFiltrado.toLowerCase());
        }
      )
      .filter(
        (pokemon) => {
          return pokemon.poderUno.toLowerCase().includes(this.poderUnoFiltrado.toLowerCase());
        }
      )
      .filter(
        (pokemon) => {
          return pokemon.poderDos.toLowerCase().includes(this.poderDosFiltrado.toLowerCase());
        }
      )
      .filter(
        (pokemon) => {
          return pokemon.fechaCaptura.toLowerCase().includes(this.fechacapturaFiltrado.toLowerCase());
        }
      );
  }
}
