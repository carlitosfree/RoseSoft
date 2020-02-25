import {Component, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {ChongoRestService} from '../../Services/chongo-rest.service';
import {MatDialog} from '@angular/material/dialog';
import {ModalEditarChongoComponent} from '../../modales/modal-editar-chongo/modal-editar-chongo.component';
import {ModalEditarProstitutaComponent} from '../../modales/modal-editar-prostituta/modal-editar-prostituta.component';
import {UsuarioRestService} from '../../Services/usuario-rest.service';
import {ModalEditarUsuarioComponent} from '../../modales/modal-editar-usuario/modal-editar-usuario.component';
import {Router} from '@angular/router';

@Component({
  selector: 'app-chongo',
  templateUrl: './chongo.component.html',
  styleUrls: ['./chongo.component.scss']
})
export class ChongoComponent implements OnInit {
  url = 'http://localhost:1338';
  filas = 3;
  busquedaChongo = '';
  chongo = [];
  usuarios = [];
  busquedaApellido = '';

  constructor(
    private readonly _httpClient: HttpClient,
    private readonly _chongoRestService: ChongoRestService,
    private readonly __matDialog: MatDialog,
    private readonly _usuarioRestService: UsuarioRestService,
    private readonly  _router: Router,
  ) {
  }

  ngOnInit() {
    this.consultarEntrenadores();
    this.consultarUsuarios();
  }

  consultarEntrenadores() {
    const urlUsuario = this.url + '/usuario';
    const chongo$ = this._httpClient
      .get(urlUsuario);
    chongo$
      .subscribe(
        (usuarios: any[]) => {
          this.usuarios = usuarios;
        },
        (error) => {
          console.error({
            error,
            mensaje: 'Error consultando usuario',
          });
        }
      );
  }

  consultarUsuarios() {
    const urlChongo = this.url + '/chongo';
    const chongo$ = this._httpClient
      .get(urlChongo);
    chongo$
      .subscribe(
        (chongo: any[]) => {
          this.chongo = chongo;
        },
        (error) => {
          console.error({
            error,
            mensaje: 'Error consultando chongo',
          });
        }
      );
  }

  ingresar() {
    const matDialogRefModalIngresarChongo = this.__matDialog
      .open(
        ModalEditarChongoComponent,
        {
          width: '500px',
        }
      );
    const respuestaDialog$ = matDialogRefModalIngresarChongo
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
        () => {
        }
      );
  }

  ingresarEntrenadorHttp(datos) {
    const chongoIngresadoS = this._chongoRestService
      .ingresar(datos);
    chongoIngresadoS
      .subscribe(
        (chongoIngresado) => {
          this.chongo.push(chongoIngresado);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  eliminar(chongo) {
    const eliminar$ = this._chongoRestService
      .eliminar(chongo.id);
    eliminar$
      .subscribe(
        (chongoEliminado) => {
          const indice = this.chongo
            .findIndex(
              (chongoBuscado) => {
                return chongoBuscado.id === chongoEliminado.id;
              }
            );
          this.chongo.splice(indice, 1);
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  buscar() {
    const busqueda$ = this._chongoRestService
      .buscar(this.busquedaChongo);
    busqueda$
      .subscribe(
        (chongoEncontrados) => {
          this.chongo = chongoEncontrados;
        },
        (error) => {
          console.log('Error: ', error);
        }
      );
  }

  editar(entrenador) {
    console.log('Estos datos se recibe del chongo: ', entrenador);
    const matDialogRefModalEditarProtistuta = this.__matDialog
      .open(
        ModalEditarChongoComponent,
        {width: '500', data: {entrenador}}
      );
    const respuestaDialog$ = matDialogRefModalEditarProtistuta
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
    const chongoEditado$ = this._chongoRestService
      .editar(id, datosEditar);
    chongoEditado$
      .subscribe(
        (chongoEdit: any) => {
          console.log('Usuario editado: ', chongoEdit);
          const indice = this.chongo
            .findIndex(
              (entrenador) => {
                return entrenador.id === id;
              }
            );
          this.chongo[indice].nombreChongoris = datosEditar.nombreChongoris;
          this.chongo[indice].direccion = datosEditar.direccion;
          this.chongo[indice].fechaApertura = datosEditar.fechaApertura;
          this.chongo[indice].numeroEstrellas = datosEditar.numeroEstrellas;
          this.chongo[indice].horarioApertura = datosEditar.horarioApertura;
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

