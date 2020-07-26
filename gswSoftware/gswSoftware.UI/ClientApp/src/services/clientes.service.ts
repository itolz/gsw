import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../models/Cliente';
import { AccountService } from '../services/account.service';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor(private http: HttpClient,
              private accountService: AccountService
  ) {

  }

  
  ListarClientes(): Observable<Array<Cliente>> {

    var header = {
      headers: new HttpHeaders().set('Authorization', 'Bearer ' + this.accountService.getToken())
    }
    
    return <Observable<Array<Cliente>>>this.http.get('https://localhost:44357/cliente/ListarClientes',header);
  }

  ListarClientesPublico(): Observable<Array<Cliente>> {

    return <Observable<Array<Cliente>>>this.http.get('https://localhost:44357/cliente/ListarClientesPublico');
  }

  InserirCliente(cliente: Cliente): Observable<Cliente> {

    var header = {
      headers: new HttpHeaders().set('Authorization', 'Bearer ' + this.accountService.getToken())
    }
    return <Observable<Cliente>>this.http.post('https://localhost:44357/cliente/InserirCliente', cliente, header);
  }

  EditarCliente(cliente: Cliente): Observable<Cliente> {
    var header = {
      headers: new HttpHeaders().set('Authorization', 'Bearer ' + this.accountService.getToken())
    }
    return <Observable<Cliente>>this.http.put('https://localhost:44357/cliente/EditarCliente', cliente, header);
  }

  ExcluirCliente(id: number): Observable<Cliente> {
    var header = {
      headers: new HttpHeaders().set('Authorization', 'Bearer ' + this.accountService.getToken())
    }
      return<Observable< Cliente >> this.http.delete('https://localhost:44357/cliente/ExcluirCliente' +'/' + id,  header);
  }
}
