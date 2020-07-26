import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../../services/clientes.service';
import { AtmService } from '../../services/atm.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Saque } from '../../models/saque';
import { IRetornoOperacao } from '../../models/IRetornoOperacao';
import { ICedula } from '../../models/ICedula';

@Component({
  selector: 'app-atm',
  templateUrl: './atm.component.html',
  styleUrls: ['./atm.component.css']
})
export class AtmComponent implements OnInit {
  formSaque: FormGroup;
  retornoOperacao: IRetornoOperacao;
  cedulasDispensadas: Array<ICedula>;
  valorSaque: number; 

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
    private formBuilder: FormBuilder) { }

  ngOnInit() {

    this.createForm(new Saque());

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
        this.retornoOperacao = data as IRetornoOperacao;
        this.cedulasDispensadas = this.retornoOperacao.cedulasDispensadas as Array<ICedula>;
        

        if (this.retornoOperacao.tipoRetorno == 0) {
          this.notas10 = (this.cedulasDispensadas.filter(c => c.cedula == 10)).length;
          this.notas20 = (this.cedulasDispensadas.filter(c => c.cedula == 20)).length;
          this.notas50 = (this.cedulasDispensadas.filter(c => c.cedula == 50)).length;
          this.notas100 = (this.cedulasDispensadas.filter(c => c.cedula == 100)).length;


          this.relatorioDispensaNotas = true;
          this.formularioVisivel = false;
        }
        this.novoSaqueBotao = true;
      }
    )
  }

  novoSaque() {
    console.log('novo saque');
    this.createForm(new Saque());
    this.relatorioDispensaNotas = false;
    this.retornoOperacao = null;
    this.novoSaqueBotao = false;
    this.formularioVisivel = true;

  }

}
