import { Pessoa } from "./Pessoa";
import { unidadeAtendimento } from "./unidadeAtendimento";

export class Barbeiro extends Pessoa{
    id: number;
    unidadeId : number = 0;
    unidade : unidadeAtendimento | undefined;
    constructor(){
        super();
        this.id=0;
    }
}