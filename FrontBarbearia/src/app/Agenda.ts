import { AtendimentoAgendado } from "./AtendimentoAgendado";
import { Barbeiro } from "./Barbeiro";
import { HorarioLivre } from "./HorarioLivre";


export class Agenda {
    id: number = 0;
    barbeiroId: number = 0;
    barbeiro: Barbeiro | undefined;
    atendimentos: Array<AtendimentoAgendado> | undefined;
    horarios : Array<Date> |undefined; 
}