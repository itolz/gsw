import { Injectable, EventEmitter, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from '../models/Cliente';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  @Output() getLoggedInName: EventEmitter<any> = new EventEmitter();

  constructor(private http: HttpClient) { }

  Login(login: Cliente): Observable<Cliente> {

    console.log('metodo login');
    console.log(login);

    if (login.role == "admin")
      return <Observable<Cliente>>this.http.post('https://localhost:44357/account/login', login);
    else {
      localStorage.setItem("nome", login.nome);
      localStorage.setItem("id", login.id.toString());
      localStorage.setItem("login", login.userName);
      localStorage.removeItem("token");
      this.getLoggedInName.emit(login.userName);

    }

  }

  getToken(): string {
    let token = localStorage.getItem('token');
    return token;
  }

  getUserName(): string {
    let userName = localStorage.getItem('login');
    if (userName == null)
      userName = ''

    return userName;
  }



  getNome(): string {
    console.log('getnome');
    let nome = localStorage.getItem('nome');
    return nome;
  }

  getId(): number {
    console.log('id');
    let id = localStorage.getItem('id');
    return +id;
  }

  logOff() {
    localStorage.removeItem('token');
    localStorage.removeItem('login');
    localStorage.removeItem('nome');
    localStorage.removeItem('id');
  }
}
