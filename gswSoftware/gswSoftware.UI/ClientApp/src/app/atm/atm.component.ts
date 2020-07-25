import { Component, OnInit } from '@angular/core';
import { ClientesService} from '../../services/clientes.service';
import { ICliente } from '../../models/ICliente';

@Component({
  selector: 'app-atm',
  templateUrl: './atm.component.html',
  styleUrls: ['./atm.component.css'],
  providers: [ClientesService]
})  
export class AtmComponent implements OnInit {

  constructor(private clientesService: ClientesService) { }

  ngOnInit() {
    this.listarClientes();
  }

  listaClientes: Array<ICliente> = []; 

  listarClientes() {
    this.clientesService.listarClientes().subscribe(
      data => {
        this.listaClientes = data as Array<ICliente>;
        console.log(this.listaClientes);
      }
    )
  }

}
