import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {RutaLoginComponent} from "./Rutas/ruta-login/ruta-login.component";
import {ProstitutaComponent} from "./Rutas/prostituta/prostituta.component";
import {ChongoComponent} from "./Rutas/chongo/chongo.component";
import {TiendaComponent} from "./Rutas/tienda/tienda.component";
import {UsuarioComponent} from "./Rutas/usuario/usuario.component";
import {EstaLogueadoPolicy} from "./politicas/esta-logueado.policy";
import {EstaLogueadoAdminPolicy} from "./politicas/esta-logueado-admin.policy";


const routes: Routes = [
  {
    path: 'login',
    component: RutaLoginComponent
  },
  {
    path: 'chongo',
    component: ChongoComponent,
    canActivate: [
      EstaLogueadoAdminPolicy
    ]
  },
  {
    path: 'chongo/:idChongo/prostituta',
    component: ProstitutaComponent,
    canActivate: [
      EstaLogueadoAdminPolicy
    ]
  },
  {
    path: 'tienda',
    component: TiendaComponent,
    canActivate: [
      EstaLogueadoPolicy
    ]
  },
  {
    path: 'usuario',
    component: UsuarioComponent,
    canActivate: [
      EstaLogueadoPolicy
    ]
  },
  {
    path: '',
    redirectTo: '/login',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
