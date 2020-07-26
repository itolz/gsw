import { Injectable } from '@angular/core';
import { Saque} from '../models/saque';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RetornoOperacao } from '../models/IRetornoOperacao';


@Injectable({
  providedIn: 'root'
})
export class AtmService {

  constructor(private http: HttpClient) { }

  OperarSaque(saque: Saque): Observable<RetornoOperacao> {
    return <Observable<RetornoOperacao>>this.http.post('https://localhost:44357/atm/OperarSaque', saque);
  }
}
