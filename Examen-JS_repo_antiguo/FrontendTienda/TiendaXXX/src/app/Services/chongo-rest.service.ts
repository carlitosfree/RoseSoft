import {Injectable} from '@angular/core';
import {environment} from '../../environments/environment';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root',
})

export class ChongoRestService {
  url = environment.url + 'entrenador';
  constructor(
    private readonly _httpClient: HttpClient,
  ) {
  }
  editar(id: number, datos): Observable<any> {
    const urlEditar = this.url + '/' + id;
    return this._httpClient
      .put(
        urlEditar,
        datos
      );
  }
  eliminar(id: number): Observable<any> {
    const urlEliminar = this.url + '/' + id;
    return this._httpClient
      .delete(
        urlEliminar
      );
  }
  ingresar(datos): Observable<any> {
    const urlIngresar = this.url;
    return this._httpClient
      .post(
        urlIngresar,
        datos,
      );
  }
  buscar(busqueda: string): Observable<any> {
    let consulta = '';
    if (busqueda) {
      consulta = '?nombre=' + busqueda;
    }
    const urlBuscar = this.url + consulta;
    return this._httpClient
      .get(
        urlBuscar,
      );
  }
}
