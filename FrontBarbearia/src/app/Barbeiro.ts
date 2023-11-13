import { Pessoa } from "./Pessoa";

export class Barbeiro extends Pessoa{
    barbeiroId: number;
    constructor(){
        super();
        this.barbeiroId=0;
    }
}