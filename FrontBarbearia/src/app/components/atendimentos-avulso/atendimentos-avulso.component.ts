import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observer } from 'rxjs';

import { AtendimentosAvulsoService } from 'src/app/atendimentos-avulso.service';
import { AtendimentoAvulso } from 'src/app/AtendimentoAvulso';
import { Servico } from 'src/app/Servico';
import { ClientesService } from 'src/app/clientes.service';
import { ServicosService } from 'src/app/servicos.service';
import { Cliente } from 'src/app/Cliente';

@Component({
  selector: 'app-atendimentos-avulso',
  templateUrl: './atendimentos-avulso.component.html',
  styleUrls: ['./atendimentos-avulso.component.css']
})
export class AtendimentosAvulsoComponent implements	OnInit{
  constructor(private atendimentoService: AtendimentosAvulsoService, private clienteService:ClientesService,
              private servicoService: ServicosService){}
  formulario: any;
  formularioBusca:any;
  formularioListar:any;
  formularioExcluir:any;
  formularioAlterar:any;
  servicos: Array<Servico> | undefined;
  clientes: Array<Cliente> | undefined;
  atendimentos:Array<AtendimentoAvulso> | undefined;
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
    const observer: Observer<AtendimentoAvulso> = {
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
    const observer: Observer<AtendimentoAvulso> = {
      
      next: (atendimento: AtendimentoAvulso) => {
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
      const observer: Observer<Array<AtendimentoAvulso>> = {
        next:(atendimentos: Array<AtendimentoAvulso>) => {
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
    
  }
  alterar():void{
    
  }
}
