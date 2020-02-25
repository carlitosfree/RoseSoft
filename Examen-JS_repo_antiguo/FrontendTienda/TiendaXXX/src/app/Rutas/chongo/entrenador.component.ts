import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {ChongoRestService} from '../../Services/chongo-rest.service';
import {MatDialog} from '@angular/material/dialog';
import {ModalEditarChongoComponent} from "../../modales/modal-editar-chongo/modal-editar-chongo.component";
import {ModalEditarProstitutaComponent} from "../../modales/modal-editar-prostituta/modal-editar-prostituta.component";
import {UsuarioRestService} from "../../Services/usuario-rest.service";
import {ModalEditarUsuarioComponent} from "../../modales/modal-editar-usuario/modal-editar-usuario.component";
import {Router} from "@angular/router";

@Component({
  selector: 'app-entrenador',
  templateUrl: './entrenador.component.html',
  styleUrls: ['./entrenador.component.scss']
})
export class EntrenadorComponent implements OnInit {
  url = 'http://localhost:1338';
  filas = 3;
  busquedaEntrenador = '';
  entrenadores = [];
  usuarios = [];
  busquedaApellido = '';
  constructor(
    private readonly _httpClient: HttpClient,
    private readonly _entrenadorRestService: ChongoRestService,
    private readonly __matDialog: MatDialog,
    private readonly _usuarioRestService: UsuarioRestService,
    private readonly  _router: Router,
  ) { }

  ngOnInit() {
    this.consultarEntrenadores();
    this.consultarUsuarios();
  }
  consultarEntrenadores() {
    const urlUsuario = this.url + '/usuario';
    const entrenador$ = this._httpClient
      .get(urlUsuario);
    entrenador$
      .subscribe(
        (usuarios: any[]) => {
          this.usuarios = usuarios;
        },
        (error) => {
          console.error({
            error: error,
            mensaje: 'Error consultando usuario',
          });
        }
      );
  }

  consultarUsuarios() {
    const urlEntrenador = this.url + '/chongo';
    const entrenador$ = this._httpClient
      .get(urlEntrenador);
    entrenador$
      .subscribe(
        (entrenadores: any[]) => {
          this.entrenadores = entrenadores;
        },
        (error) => {
          console.error({
            error: error,
            mensaje: 'Error consultando chongo',
          });
        }
      );
  }
  ingresar() {
    const matDialogRefModalIngresarEntrenador =  this.__matDialog
      .open(
        ModalEditarChongoComponent,
        {width: '500px',
        }
      );
    const respuestaDialog$ = matDialogRefModalIngresarEntrenador
      .afterClosed();
    respuestaDialog$
      .subscribe(
        (datos) => {
          if (datos) {
            this.ingresarEntrenadorHttp(datos);
          } else {
            // undefined
          }
        },
        () => {}
      );
  }
  ingresarEntrenadorHttp(datos) {
    const entrenadorIngresadoS = this._entrenadorRestService
      .ingresar(datos);
    entrenadorIngresadoS
      .subscribe(
        (entrenadorIngresado) => {
          this.entrenadores.push(entrenadorIngresado);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  eliminar(entrenador) {
    const eliminar$ = this._entrenadorRestService
      .eliminar(entrenador.id);
    eliminar$
      .subscribe(
        (entrenadorEliminado) => {
          const indice = this.entrenadores
            .findIndex(
              (entrenadorBuscado) => {
                return entrenadorBuscado.id === entrenadorEliminado.id;
              }
            );
          this.entrenadores.splice(indice, 1);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  buscar() {
    const busqueda$ = this._entrenadorRestService
      .buscar(this.busquedaEntrenador);
    busqueda$
      .subscribe(
        (entrenadoresEncontrados) => {
          this.entrenadores = entrenadoresEncontrados;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  editar(entrenador) {
    console.log('Estos datos se recibe del chongo: ', entrenador);
    const matDialogRefModalEditarPokemon = this.__matDialog
      .open(
        ModalEditarChongoComponent,
        {width: '500', data: {entrenador}}
      );
    const respuestaDialog$ = matDialogRefModalEditarPokemon
      .afterClosed();
    respuestaDialog$
      .subscribe(
        (datosEditados) => {
          console.log('Estos son los datos editados: ', datosEditados);
          if (datosEditados) {
            this.editarEntrenadorHttp(entrenador.id, datosEditados);
          } else {
            // undefined
          }
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  editarEntrenadorHttp(id, datosEditar) {
    const entrenadorEditado$ = this._entrenadorRestService
      .editar(id, datosEditar);
    entrenadorEditado$
      .subscribe(
        (entrenadorEdit: any) => {
          console.log('Usuario editado: ', entrenadorEdit);
          const indice = this.entrenadores
            .findIndex(
              (entrenador) => {
                return entrenador.id === id;
              }
            );
          this.entrenadores[indice].nombre = datosEditar.nombre;
          this.entrenadores[indice].apellido = datosEditar.apellido;
          this.entrenadores[indice].fechaNacimiento = datosEditar.fechaNacimiento;
          this.entrenadores[indice].numeroMedalla = datosEditar.numeroMedalla;
          this.entrenadores[indice].campeonActual = datosEditar.campeonActual;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  buscarApellido() {
    const busqueda$ = this._usuarioRestService
      .buscar(this.busquedaApellido);
    busqueda$
      .subscribe(
        (usuariosEncontrados) => {
          this.usuarios = usuariosEncontrados;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  eliminarU(usuario) {
    const eliminar$ = this._usuarioRestService
      .eliminar(usuario.id);
    eliminar$
      .subscribe(
        (usuarioEliminado) => {
          const indice = this.usuarios
            .findIndex(
              (usuarioBuscado) => {
                return usuarioBuscado.id === usuarioEliminado.id;
              }
            );
          this.usuarios.splice(indice, 1);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );

  }
  editarU(usuario) {
    console.log('Estos datos se recibe del chongo: ', usuario);
    const matDialogRefModalEditarUsuario = this.__matDialog
      .open(
        ModalEditarUsuarioComponent,
        {width: '500', data: {usuario}}
      );
    const respuestaDialog$ = matDialogRefModalEditarUsuario
      .afterClosed();
    respuestaDialog$
      .subscribe(
        (datosEditados) => {
          console.log('Estos son los datos editados: ', datosEditados);
          if (datosEditados) {
            this.editarUsuarioHttp(usuario.id, datosEditados);
          } else {
            // undefined
          }
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
  salir() {
    this._router.navigate(['/login']);
  }
  editarUsuarioHttp(id, datosEditar) {
    const usuarioEditado$ = this._usuarioRestService
      .editar(id, datosEditar);
    usuarioEditado$
      .subscribe(
        (usuarioEdit: any) => {
          console.log('Usuario editado: ', usuarioEdit);
          const indice = this.usuarios
            .findIndex(
              (usuario) => {
                return usuario.id === id;
              }
            );
          this.usuarios[indice].nombre = datosEditar.nombre;
          this.usuarios[indice].apellido = datosEditar.apellido;
          this.usuarios[indice].nickname = datosEditar.nickname;
          this.usuarios[indice].correo = datosEditar.correo;
          this.usuarios[indice].edad = datosEditar.edad;
          this.usuarios[indice].rol = datosEditar.rol;

        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }
}

