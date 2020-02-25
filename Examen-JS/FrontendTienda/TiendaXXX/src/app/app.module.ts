import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RutaLoginComponent } from './Rutas/ruta-login/ruta-login.component';

import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import {ButtonModule} from 'primeng/button';
import {TableModule} from 'primeng/table';
import {InputTextModule} from 'primeng/inputtext';
import {AuthService} from './Services/auth/auth.service';
import { ProstitutaComponent } from './Rutas/prostituta/prostituta.component';
import { ChongoComponent } from './Rutas/chongo/chongo.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {ProstitutaRestService} from './Services/prostituta-rest.service';
import { ModalEditarProstitutaComponent } from './modales/modal-editar-prostituta/modal-editar-prostituta.component';
import {MatDialogModule} from "@angular/material/dialog";
import {ChongoRestService} from "./Services/chongo-rest.service";
import { ModalEditarChongoComponent } from './modales/modal-editar-chongo/modal-editar-chongo.component';
import { TiendaComponent } from './Rutas/tienda/tienda.component';
import { UsuarioComponent } from './Rutas/usuario/usuario.component';
import { UsuarioAdmComponent } from './Rutas/usuario-adm/usuario-adm.component';
import {TabViewModule} from 'primeng/tabview';
import {PanelModule} from 'primeng/panel';
import {CardModule} from 'primeng/card';
import { ModalSeleccionarProstitutaComponent } from './modales/modal-seleccionar-prostituta/modal-seleccionar-prostituta.component';
import { ModalRegitrarUsuarioComponent } from './modales/modal-regitrar-usuario/modal-regitrar-usuario.component';
import { ModalVisualizarCompraComponent } from './modales/modal-visualizar-compra/modal-visualizar-compra.component';
import { ModalEditarUsuarioComponent } from './modales/modal-editar-usuario/modal-editar-usuario.component';



@NgModule({
  declarations: [
    AppComponent,
    ModalEditarProstitutaComponent,
    RutaLoginComponent,
    ProstitutaComponent,
    ChongoComponent,
    ModalEditarChongoComponent,
    TiendaComponent,
    UsuarioComponent,
    UsuarioAdmComponent,
    ModalSeleccionarProstitutaComponent,
    ModalRegitrarUsuarioComponent,
    ModalVisualizarCompraComponent,
    ModalEditarUsuarioComponent,
  ],
  entryComponents: [
    ModalEditarProstitutaComponent,
    ModalEditarChongoComponent,
    ModalSeleccionarProstitutaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ButtonModule,
    TableModule,
    BrowserAnimationsModule,
    MatDialogModule,
    TabViewModule,
    PanelModule,
    CardModule
  ],
  providers: [AuthService, ProstitutaRestService, ChongoRestService ],
  bootstrap: [AppComponent]
})

export class AppModule { }


