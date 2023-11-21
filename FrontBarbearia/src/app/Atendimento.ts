import { Barbeiro } from "./Barbeiro";
import { Cliente } from "./Cliente";
import { Servico } from "./Servico";

export abstract class Atendimento {
    id: number = 0;
    servicoId: number= 0;
    servico: Servico| undefined;
    clienteId: number = 0;
    cliente: Cliente | undefined;
}