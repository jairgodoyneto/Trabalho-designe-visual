import { Barbeiro } from "./Barbeiro";
export class unidadeAtendimento {
    id : number = 0;
    endereco:string ='';
    cep: string ='';
    funcionarios: Array<Barbeiro> | undefined;
}