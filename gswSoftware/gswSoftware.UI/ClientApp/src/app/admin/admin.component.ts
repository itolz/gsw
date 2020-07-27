import { Component, OnInit } from '@angular/core';
import { Cliente } from '../../models/Cliente';
import { ClientesService } from '../../services/clientes.service';
import { AccountService } from '../../services/account.service';

import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from "@angular/router"




@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css'],
  providers: [ClientesService]
})
export class AdminComponent implements OnInit {
  formCliente: FormGroup;
  operacaoCrudEditar: boolean;

  formularioVisivel: boolean = false;
  gridVisivel: boolean = true; 

  constructor(private clientesService: ClientesService,
              private router: Router,
    private accountService: AccountService,
    private formBuilder: FormBuilder) { }

  ngOnInit() {

    let adminToken = this.accountService.getToken();

    if (adminToken == null)
        this.router.navigate(['']);

    this.createForm(new Cliente());
    this.listarClientes();
  }

  listaClientes: Array<Cliente> = [];

  listarClientes() {
    this.clientesService.ListarClientes().subscribe(
      data => {
        this.listaClientes = data as Array<Cliente>;
        console.log(this.listaClientes);
      }
    )
  }

  createForm(cliente: Cliente) {
    this.formCliente = this.formBuilder.group(
      {
        nome: cliente.nome,
        saldo: cliente.saldo,
        role: cliente.role
      }
    )
  }

  onSubmit() {

    if (this.operacaoCrudEditar) {
      this.clientesService.EditarCliente(this.formCliente.value).subscribe(
        data => {
          console.log('cliente Editado com sucesso');
          this.listarClientes();
          this.formularioVisivel = false;
          this.gridVisivel = true;

        })
    }
    else {
      this.clientesService.InserirCliente(this.formCliente.value).subscribe(
        data => {
          console.log('cliente inserido com sucesso');
          this.listarClientes();
          this.formularioVisivel = false;
          this.gridVisivel = true; 
        }
      )
    }
  }

  IncluirCliente() {
    this.createForm(new Cliente());
    this.formularioVisivel = true;
    this.gridVisivel = false;
  }

  EditarCliente(cliente: Cliente) {
    console.log("Cliente selecionado para edição");
    console.log(cliente);
    this.operacaoCrudEditar = true;
    this.formularioVisivel = true;
    this.gridVisivel = false; 
    this.createForm(cliente);
  }

  ExcluirCliente(cliente: Cliente) {
    this.operacaoCrudEditar = false;
    console.log("Cliente selecionado para exclusão");
    console.log(cliente);

    this.clientesService.ExcluirCliente(cliente.id).subscribe(
      data => {
        console.log('cliente Editado com sucesso');
        this.listarClientes();
        this.formularioVisivel = false;

      })

  }

  Cancelar() {
    this.formularioVisivel = false;
    this.gridVisivel = true; 
  }

}
