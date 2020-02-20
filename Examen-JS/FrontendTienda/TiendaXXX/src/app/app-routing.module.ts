import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {RutaLoginComponent} from "./Rutas/ruta-login/ruta-login.component";
import {PokemonComponent} from "./Rutas/prostituta/pokemon.component";
import {EntrenadorComponent} from "./Rutas/chongo/entrenador.component";
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
    component: EntrenadorComponent,
    canActivate: [
      EstaLogueadoAdminPolicy
    ]
  },
  {
    path: 'chongo/:idChongo/prostituta',
    component: PokemonComponent,
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
