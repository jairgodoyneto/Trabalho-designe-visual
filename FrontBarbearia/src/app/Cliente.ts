import { Pessoa } from "./Pessoa";

export class Cliente extends Pessoa{
    id: number;
    constructor(){
        super();
        this.id=0;
    }
}