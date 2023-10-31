import { Pessoa } from "./Pessoa";

export class Barbeiro extends Pessoa{
    barbeiroId: number;
    constructor(barbeiroId: number, nome:string,cpf:string,email:string){
        super(nome,cpf,email);
        this.barbeiroId=barbeiroId;
    }
}