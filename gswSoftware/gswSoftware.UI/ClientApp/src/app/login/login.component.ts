import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AccountService } from '../../services/account.service';
import { Cliente } from '../../models/Cliente';
import { Router } from "@angular/router"



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  formLogin: FormGroup;
  mensagemErro: boolean;


  constructor(private accountService: AccountService,
    private router: Router,
    private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.createForm(new Cliente());
    this.mensagemErro = false; 
  }

  createForm(cliente: Cliente) {
    this.formLogin = this.formBuilder.group(
      {
        userName: cliente.userName,
        password: cliente.password,
        role: 'admin'
      }
    )
  }

  onSubmit() {
    console.log('chamado service login');


    this.accountService.Login(this.formLogin.value).subscribe(
      data => {

        if ((data == undefined || data == null)) {

          console.log('Erro no Usuário ou Senha');
          this.mensagemErro = true; 
        }
        else {

          let login = data as Cliente;
          localStorage.setItem('token', login.token);
          localStorage.setItem('login', login.userName);
          localStorage.setItem('nome', login.nome);
          localStorage.setItem('id', login.id.toString());

          this.router.navigate(['/atm']);

        }
      }
    );

    //this.router.navigateByUrl('/admin', { skipLocationChange: true }).then(() => {
    //  this.router.navigate(['/login']);


    //});
  }


  Cancelar() {
    this.router.navigate([''])
  }

}
