import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IRetornoOperacao } from '../models/IRetornoOperacao';
import { Observable } from 'rxjs';
import { ICliente } from '../models/ICliente';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor(private http: HttpClient) { }

  
  listarClientes(): Observable<Array<ICliente>> {
    return <Observable<Array<ICliente>>>this.http.get('https://localhost:44357/cliente/ListarClientes');
  }
}
