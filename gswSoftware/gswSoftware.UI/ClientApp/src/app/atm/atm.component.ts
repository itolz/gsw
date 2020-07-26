import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../../services/clientes.service';
import { AtmService } from '../../services/atm.service';
import { AccountService } from '../../services/account.service';

import { FormBuilder, FormGroup } from '@angular/forms';
import { Saque } from '../../models/saque';
import { RetornoOperacao } from '../../models/RetornoOperacao';
import { Cedula } from '../../models/Cedula';

@Component({
  selector: 'app-atm',
  templateUrl: './atm.component.html',
  styleUrls: ['./atm.component.css']
})
export class AtmComponent implements OnInit {
  formSaque: FormGroup;
  retornoOperacao: RetornoOperacao;
  cedulasDispensadas: Array<Cedula>;
  valorSaque: number;
  nome: string

  //controles de usabilidade
  relatorioDispensaNotas: boolean = false;
  novoSaqueBotao: boolean = false;
  formularioVisivel: boolean = true;

  notas10: number = 0;
  notas20: number = 0;
  notas50: number = 0;
  notas100: number = 0;

  constructor(private clientesService: ClientesService,
    private atmService: AtmService,
    private accountService: AccountService,
    private formBuilder: FormBuilder) {
    let nomeLogado = this.accountService.getNome();

    this.nome = 'Olá ' + nomeLogado;
  }

  ngOnInit() {
    console.log('chamada createform');
    let id = this.accountService.getId();

    console.log(id);
    this.createForm(new Saque(id));

  }

  createForm(saque: Saque) {
    this.formSaque = this.formBuilder.group(
      {
        id: saque.id,
        valorSolicitado: saque.valorSolicitado
      }
    )
  }

  


  onSubmit() {

    this.atmService.OperarSaque(this.formSaque.value).subscribe(
      data => {
        this.retornoOperacao = data as RetornoOperacao;
        this.cedulasDispensadas = this.retornoOperacao.cedulasDispensadas as Array<Cedula>;
        

        if (this.retornoOperacao.tipoRetorno == 0) {
          this.notas10 = (this.cedulasDispensadas.filter(c => c.cedula == 10)).length;
          this.notas20 = (this.cedulasDispensadas.filter(c => c.cedula == 20)).length;
          this.notas50 = (this.cedulasDispensadas.filter(c => c.cedula == 50)).length;
          this.notas100 = (this.cedulasDispensadas.filter(c => c.cedula == 100)).length;


          this.relatorioDispensaNotas = true;
        }
        this.formularioVisivel = false;
        this.novoSaqueBotao = true;
      }
    )
  }

  novoSaque() {
    console.log('novo saque');
    this.createForm(new Saque(this.accountService.getId()));
    this.relatorioDispensaNotas = false;
    this.retornoOperacao = null;
    this.novoSaqueBotao = false;
    this.formularioVisivel = true;

  }

}
