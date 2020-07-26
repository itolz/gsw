import { Cedula } from "./ICedula";

export class RetornoOperacao {
  mensagemRetornoAmigavel: string;
  cedulasDispensadas: Array<Cedula>;
  tipoRetorno: number;
  valorSaque: number;
}
