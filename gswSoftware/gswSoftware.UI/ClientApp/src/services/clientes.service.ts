import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../models/Cliente';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor(private http: HttpClient) { }

  
  ListarClientes(): Observable<Array<Cliente>> {
    return <Observable<Array<Cliente>>>this.http.get('https://localhost:44357/cliente/ListarClientes');
  }

  InserirCliente(cliente: Cliente): Observable<Cliente> {
    return <Observable<Cliente>>this.http.post('https://localhost:44357/cliente/InserirCliente', cliente);
  }

  EditarCliente(cliente: Cliente): Observable<Cliente> {
    return <Observable<Cliente>>this.http.put('https://localhost:44357/cliente/EditarCliente', cliente);
  }

   ExcluirCliente(id:number): Observable < Cliente > {
      return<Observable< Cliente >> this.http.delete('https://localhost:44357/cliente/ExcluirCliente' +'/' + id);
  }
}
