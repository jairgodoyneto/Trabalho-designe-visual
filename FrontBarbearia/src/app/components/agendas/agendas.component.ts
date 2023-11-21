import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observer } from 'rxjs';
import { Agenda } from 'src/app/Agenda';

import { Servico } from 'src/app/Servico';
import { AgendasService } from 'src/app/agendas.service';
import { AtendimentoAgendado } from 'src/app/AtendimentoAgendado';
import { Barbeiro } from 'src/app/Barbeiro';
import { BarbeirosService } from 'src/app/barbeiros.service';
import { ServicosService } from 'src/app/servicos.service';
import { HorarioLivreService } from 'src/app/horario-livre.service';
import { HorarioLivre } from 'src/app/HorarioLivre';

@Component({
  selector: 'app-agendas',
  templateUrl: './agendas.component.html',
  styleUrls: ['./agendas.component.css']
})
export class AgendasComponent implements	OnInit{
  constructor( private barbeiroService:BarbeirosService,private servicoService: ServicosService,
     private agendasService: AgendasService,private horarioService:HorarioLivreService){}
  formulario: any;
  formularioBusca:any;
  formularioListar:any;
  formularioExcluir:any;
  formularioAlterar:any;
  FormularioInserirHorarioLivre:any;
  servicos: Array<Servico> | undefined;
  barbeiros: Array<Barbeiro> | undefined;
  agenda: Agenda|undefined;
  agendas:Array<Agenda> | undefined;
  livre?:HorarioLivre;
  ngOnInit(): void {
    this.agendasService.listar().subscribe(agendas=>{
      this.agendas=agendas;
      if (this.agendas && this.agendas.length >0) {
        this.formulario.get('servicoId')?.setValue(this.agendas[0].id);
      }
    })
    this.barbeiroService.listar().subscribe(barbeiros=>{
      this.barbeiros= barbeiros;
      if (this.barbeiros && this.barbeiros.length > 0) {
        this.formulario.get('clienteId')?.setValue(this.barbeiros[0].id);
      }
    })
    this.formulario = new FormGroup({
      barbeiroId : new FormControl(null)
    })
    this.FormularioInserirHorarioLivre = new FormGroup({
      id:new FormControl(null),
      ano:new FormControl(null),
      mes: new FormControl(null),
      dia: new FormControl(null),
      hora: new FormControl(null),
      minuto: new FormControl(null),
    })
    this.formularioBusca = new FormGroup({
      id: new FormControl(null),
      barbeiroId : new FormControl(null),
    })
    this.formularioListar = new FormGroup({
      id: new FormControl(null),
      barbeiroId : new FormControl(null)
    })
    this.formularioExcluir = new FormGroup({
      id: new FormControl(null)
    })
    this.formularioAlterar = new FormGroup({
      id: new FormControl(null),
      barbeiroId : new FormControl(null)
    })
  }
  enviarCadastro(): void{
    const agenda = this.formulario.value;
    const observer: Observer<Agenda> = {
      next(_result): void {
        alert('Atendimento salvo com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
    this.agendasService.cadastrar(agenda).subscribe(observer);
  }
  inserirHorarioLivre():void{
    if (this.agenda == null){
      alert("Agenda ainda não procurada")
    }
    else{
      this.livre?.horario?.setFullYear(this.FormularioInserirHorarioLivre.get('ano'));
      this.livre?.horario?.setMonth(this.FormularioInserirHorarioLivre.get('mes'));
      this.livre?.horario?.setDate(this.FormularioInserirHorarioLivre.get('dia'));
      this.livre?.horario?.setHours(this.FormularioInserirHorarioLivre.get('hora'));
      this.livre?.horario?.setMinutes(this.FormularioInserirHorarioLivre.get('minuto'));
      const observer1: Observer<HorarioLivre> = {
      next(_result): void {
        alert('Horario cadastrado com sucesso.');
      },
      error(_error): void {
        alert('Erro ao cadastrar!');
      },
      complete(): void {
      },
    };
    }
  }
  realizarBusca(): void {
    const id = this.formularioBusca.get('id').value;
    const observer: Observer<Agenda> = {
      next: (Agenda: Agenda) => {
        alert('Atendimento encontrado com sucesso.');
        this.agenda=Agenda;
        this.formularioBusca.get('barbeiroId').setValue(this.agenda.barbeiroId);
      },
      error(_error): void {
        alert('Erro ao procurar!');
      },
      complete(): void {
      },
    };
    this.agendasService.buscar(id).subscribe(observer);
  }
  listarAtendimentos():void{
      const observer: Observer<Array<Agenda>> = {
        next:(agendas: Array<Agenda>) => {
          alert('Atendimentos encontrado com sucesso.');
          this.agendas=agendas;
        },
        error(_error) {
          alert('Erro ao procurar!');
        },
        complete() {
        },
      }
     this.agendasService.listar().subscribe(observer);
  }
  excluir():void {
    const id = this.formularioExcluir.get('id').value;
    const observer: Observer<Agenda> = {
      next(_result): void {
        alert('Atendimento excluido com sucesso.');
      },
      error(_error): void {
        alert('Erro ao excluir!');
      },
      complete(): void {
      },
    };
  this.agendasService.excluir(id).subscribe(observer);
}
alterar(): void{
  const agenda: Agenda = this.formularioAlterar.value;
  const observer: Observer<Agenda> = {
    next(_result): void {
      alert('Atendimento alterado com sucesso.');
    },
    error(_error): void {
      alert('Erro ao alterar!');
    },
    complete(): void {
    },
  };
  this.agendasService.atualizar(agenda).subscribe(observer);
  }
}

