import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observer } from 'rxjs';
import { AtendimentoAgendado } from 'src/app/AtendimentoAgendado';
import { Cliente } from 'src/app/Cliente';
import { Servico } from 'src/app/Servico';
import { AtendimentosAgendadoService } from 'src/app/atendimentos-agendado.service';
import { ClientesService } from 'src/app/clientes.service';
import { ServicosService } from 'src/app/servicos.service';
@Component({
  selector: 'app-atendimentos-agendado',
  templateUrl: './atendimentos-agendado.component.html',
  styleUrls: ['./atendimentos-agendado.component.css']
})
export class AtendimentosAgendadoComponent implements	OnInit{
  constructor(private atendimentoService: AtendimentosAgendadoService, private clienteService:ClientesService,
              private servicoService: ServicosService){}
  formulario: any;
  formularioBusca:any;
  formularioListar:any;
  formularioExcluir:any;
  formularioAlterar:any;
  servicos: Array<Servico> | undefined;
  clientes: Array<Cliente> | undefined;
  atendimentos:Array<AtendimentoAgendado> | undefined;
  ngOnInit(): void {
    this.servicoService.listar().subscribe(servicos=>{
      this.servicos=servicos;
      if (this.servicos && this.servicos.length >0) {
        this.formulario.get('servicoId')?.setValue(this.servicos[0].id);
      }
    })
    this.clienteService.listar().subscribe(clientes=>{
      this.clientes= clientes;
      if (this.clientes && this.clientes.length > 0) {
        this.formulario.get('clienteId')?.setValue(this.clientes[0].id);
      }
    })
    this.atendimentoService.listar().subscribe(atendimentos=>{
      this.atendimentos= atendimentos;
      if (this.atendimentos && this.atendimentos.length > 0) {
        this.formularioExcluir.get('id')?.setValue(this.atendimentos[0].id);
      }
    })
    this.formulario = new FormGroup({
      servicoId : new FormControl(null),
      clienteId : new FormControl(null)
    })
    this.formularioBusca = new FormGroup({
      id: new FormControl(null),
      servico : new FormControl(null),
      cliente : new FormControl(null)
    })
    this.formularioListar = new FormGroup({
      id: new FormControl(null),
      servicoId : new FormControl(null),
      clienteId : new FormControl(null)
    })
    this.formularioExcluir = new FormGroup({
      id: new FormControl(null)
    })
    this.formularioAlterar = new FormGroup({
      id: new FormControl(null),
      servicoId : new FormControl(null),
      clienteId : new FormControl(null)
    })
  }
  enviarCadastro(): void{
    const atendimento = this.formulario.value;
    const observer: Observer<AtendimentoAgendado> = {
      next(_result): void {
        alert('Atendimento salvo com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
    this.atendimentoService.cadastrar(atendimento).subscribe(observer);
  }
  realizarBusca(): void {
    const id = this.formularioBusca.get('id').value;
    const observer: Observer<AtendimentoAgendado> = {
      
      next: (atendimento: AtendimentoAgendado) => {
        alert('Atendimento encontrado com sucesso.');
        this.formularioBusca.get('clienteId').setValue(atendimento.clienteId);
        this.formularioBusca.get('clienteNome').setValue(atendimento.cliente?.nome);
        this.formularioBusca.get('clienteId').setValue(atendimento.servicoId);
        this.formularioBusca.get('servicoNome').setValue(atendimento.servico?.nome);
      },
      error(_error): void {
        alert('Erro ao procurar!');
      },
      complete(): void {
      },
    };
    this.atendimentoService.buscar(id).subscribe(observer);
  }
  listarAtendimentos():void{
      const observer: Observer<Array<AtendimentoAgendado>> = {
        next:(atendimentos: Array<AtendimentoAgendado>) => {
          alert('Atendimentos encontrado com sucesso.');
          this.atendimentos=atendimentos;
        },
        error(_error) {
          alert('Erro ao procurar!');
        },
        complete() {
        },
      }
     this.atendimentoService.listar().subscribe(observer);
  }
  excluir():void {
    const id = this.formularioExcluir.get('id').value;
    const observer: Observer<AtendimentoAgendado> = {
      next(_result): void {
        alert('Atendimento excluido com sucesso.');
      },
      error(_error): void {
        alert('Erro ao excluir!');
      },
      complete(): void {
      },
    };
  this.atendimentoService.excluir(id).subscribe(observer);
}
alterar(): void{
  const atendimento:AtendimentoAgendado = this.formularioAlterar.value;
  const observer: Observer<AtendimentoAgendado> = {
    next(_result): void {
      alert('Atendimento alterado com sucesso.');
    },
    error(_error): void {
      alert('Erro ao alterar!');
    },
    complete(): void {
    },
  };
  this.atendimentoService.atualizar(atendimento).subscribe(observer);
}
}
