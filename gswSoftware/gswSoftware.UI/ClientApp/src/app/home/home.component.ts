import { Component } from '@angular/core';
import { ClientesService } from '../../services/clientes.service';
import { Cliente } from '../../models/Cliente';
import { Router } from "@angular/router"
import { AccountService } from '../../services/account.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  listaClientesPublico: Array<Cliente> = [];

  constructor(private clientesService: ClientesService,
    private router: Router,
    private accountservice: AccountService
  ) { }

  ngOnInit() {

    this.listarClientesPublico();
  }

  SelecionarCliente(cliente: Cliente) {
    console.log(cliente);
    this.accountservice.Login(cliente);
    this.router.navigate(['/atm'])
  }

  listarClientesPublico() {
    this.clientesService.ListarClientesPublico().subscribe(
      data => {
        this.listaClientesPublico = data as Array<Cliente>;
        console.log(this.listaClientesPublico);
      }
    )
  }

  Redirecionar() {
    this.router.navigate(['/login'])
  }


}

