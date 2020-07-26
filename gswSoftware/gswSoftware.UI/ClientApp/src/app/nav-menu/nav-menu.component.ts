import { Component } from '@angular/core';
import { AccountService } from '../../services/account.service';
import { Router } from "@angular/router"


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  userName: string;
  nome: string;

  constructor(private accountService: AccountService, private router: Router) {
    //authenticationService.getLoggedInName.subscribe(name => this.changeName(name));
    accountService.getLoggedInName.subscribe(name => this.changeName( name));


    this.userName = accountService.getUserName();

    if (this.userName === undefined) { this.userName = "login"; }



    this.nome = accountService.getNome();

    console.log(this.userName);

  }

  changeName(nome: string) {
    console.log('nome capturado');
    console.log(nome);
    this.nome = nome;
  }

  FormularioLogin() {
    let token = this.accountService.getToken();
    if (token != null) {
      this.accountService.logOff();
      this.userName = "Login";
      this.router.navigate([''])

    } else
      this.router.navigate(['/login'])
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
