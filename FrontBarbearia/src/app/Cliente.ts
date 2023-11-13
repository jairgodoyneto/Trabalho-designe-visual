import { Pessoa } from "./Pessoa";

export class Cliente extends Pessoa{
    clienteId: number;
    constructor(){
        super();
        this.clienteId=0;
    }
}