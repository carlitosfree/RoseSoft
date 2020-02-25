import {Component, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {MatDialog} from '@angular/material/dialog';
import {ProstitutaRestService} from '../../Services/prostituta-rest.service';
import {ModalEditarProstitutaComponent} from '../../modales/modal-editar-prostituta/modal-editar-prostituta.component';
import {ActivatedRoute, Router} from '@angular/router';


@Component({
  selector: 'app-prostituta',
  templateUrl: './prostituta.component.html',
  styleUrls: ['./prostituta.component.scss']
})
export class ProstitutaComponent implements OnInit {
  prostitutas = [];
  idChongo: number;
  numeroFiltrado: number;
  nombreFiltrado = '';
  prostitutaDosFiltrado = '';
  fechaIngresoFiltrado = '';
  nivelFiltrado: number;
  precioFiltrado: number;
  filas = 3;
  busquedaProstituta = '';
  url = 'http://localhost:1338';

  constructor(
    private readonly _httpClient: HttpClient,
    public readonly _matDialog: MatDialog,
    private readonly _prostitutarestService: ProstitutaRestService,
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
    const parametrosChongo$ = this._activatedRoute.params;
    parametrosChongo$
      .subscribe(
        (parametros: { idChongo: string }) => {
          this.idChongo = +parametros.idChongo;
          this.buscarProstitutaPorEntrenador(+parametros.idChongo);
        }
      );
  }

  buscarProstitutaPorEntrenador(idChongo: number) {
    const consulta = `idChongo=${idChongo}`;
    const prostituta$ = this._prostitutarestService
      .buscarPorEntrenador(consulta, this.busquedaProstituta);
    prostituta$
      .subscribe(
        (prostituta) => { // OK
          this.prostitutas = prostituta;
          console.log('zorritas', prostituta);
        },
        (error) => {  // ERROR
          console.error(error);
        }
      );
  }

  buscar() {
    const busqueda$ = this._prostitutarestService
      .buscar(this.busquedaProstituta);
    busqueda$
      .subscribe(
        (prostitutas) => {
          this.prostitutas = prostitutas;
        },
        (error) => {
          console.error(error);
        }
      );
  }

  ingresar() {
    const matDialogRefModalIngresarUsuario = this._matDialog
      .open(
        ModalEditarProstitutaComponent,
        {
          width: '500px', data: this.idChongo
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
        () => {
        }
      );
  }

  ingresarPokemonHttp(datos) {
    const prostitutasIngresadoS = this._prostitutarestService
      .ingresar(datos);
    prostitutasIngresadoS
      .subscribe(
        (pokemonIngresado) => {
          this.prostitutas.push(pokemonIngresado);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  editar(cariñosa) {
    console.log('Empieza el metodo editar con estos datos: ', cariñosa);
    const matDialogRefModalEditarProstitutas = this._matDialog
      .open(
        ModalEditarProstitutaComponent,
        {width: '500px', data: {prostituta: cariñosa}}
      );
    const respuestaDialogo$ = matDialogRefModalEditarProstitutas
      .afterClosed();
    respuestaDialogo$
      .subscribe(
        (datos) => { // try
          console.log('Esta es la respuesta del Dialogo: ', datos);
          if (datos) {
            this.editarPokemonHttp(cariñosa.id, datos);
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
    const usuarioEditado$ = this._prostitutarestService
      .editar(id, datos);
    usuarioEditado$
      .subscribe(
        (cariñosaEditado: any) => {
          console.log('Usuario editado: ', cariñosaEditado);
          const indice = this.prostitutas
            .findIndex(
              (pokemon) => {
                return pokemon.id === id;
              }
            );
          this.prostitutas[indice].numero = datos.numero;
          this.prostitutas[indice].nombre = datos.nombre;
          this.prostitutas[indice].promocionUna = datos.promocionUna;
          this.prostitutas[indice].fechaIngreso = datos.fechaIngreso;
          this.prostitutas[indice].nivel = datos.nivel;
          this.prostitutas[indice].precio = datos.precio;
          this.prostitutas[indice].idChongo.id = datos.idChongo;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  eliminar(prostituta) {
    const eliminar$ = this._prostitutarestService
      .eliminar(prostituta.id);
    eliminar$
      .subscribe(
        (prostitutaEliminado) => {
          const indice = this.prostitutas
            .findIndex(
              (prostitutaBuscado) => {
                return prostitutaBuscado.id === prostitutaEliminado.id;
              }
            );
          this.prostitutas.splice(indice, 1);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  volver() {
    this._router.navigate(['/chongo']);
  }

  protistutasFiltrados() {
    return this.prostitutas
      .filter(
        (prostituta) => {
          return prostituta.nombre.toLowerCase().includes(this.nombreFiltrado.toLowerCase());
        }
      )
      .filter(
        (prostituta) => {
          return prostituta.fechaNacimiento.toLowerCase().includes(this.fechaIngresoFiltrado.toLowerCase());
        }
      );
  }
}
