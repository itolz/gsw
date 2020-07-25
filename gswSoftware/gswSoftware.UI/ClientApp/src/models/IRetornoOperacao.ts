import { ICedula } from "./ICedula";

export interface IRetornoOperacao {
  mensagemRetornoAmigavel: string,
  cedulasDispensadas: Array<ICedula>
}
