import { Cedula } from "./Cedula";

export class RetornoOperacao {
  mensagemRetornoAmigavel: string;
  cedulasDispensadas: Array<Cedula>;
  tipoRetorno: number;
  valorSaque: number;
}
