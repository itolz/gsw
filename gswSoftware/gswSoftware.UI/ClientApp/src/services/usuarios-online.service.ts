import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UsuariosOnlineService {

  constructor(private http: HttpClient) { }


  UsuariosOnline(): Observable<number> {

    return <Observable<number>>this.http.get('https://localhost:44357/usuariosonline/usuariosonline');
  }


  adicionarUsuariosOnline(): Observable<number> {

    return <Observable<number>>this.http.get('https://localhost:44357/usuariosonline/adicionarusuario');
  }


  removerUsuariosOnline(): Observable<number> {

    return <Observable<number>>this.http.get('https://localhost:44357/usuariosonline/removerusuario');
  }
}
