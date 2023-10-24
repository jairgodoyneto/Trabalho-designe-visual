import { Pessoa } from "./Pessoa";

export class Cliente extends Pessoa{
    clienteId: number;
    constructor(clienteId: number, nome:string,cpf:string,email:string){
        super(nome,cpf,email);
        this.clienteId=clienteId;
    }
}