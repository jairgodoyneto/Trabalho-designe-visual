import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observer } from 'rxjs';
import { Barbeiro } from 'src/app/Barbeiro';
import { BarbeirosService } from 'src/app/barbeiros.service';
import { unidadeAtendimento } from 'src/app/unidadeAtendimento';
import { UnidadesAtendimentoService } from 'src/app/unidades-atendimento.service';
@Component({
  selector: 'app-unidades-atendimento',
  templateUrl: './unidades-atendimento.component.html',
  styleUrls: ['./unidades-atendimento.component.css']
})

export class UnidadesAtendimentoComponent implements OnInit {
  formulario: any;
  i:number=0;
  formularioBusca: any;
  formularioListUnidades:any;
  formularioExcluir:any;
  unidade: unidadeAtendimento | undefined;
  barbeiros: Array<Barbeiro> | undefined;
  barbeirosBusca: Array<Barbeiro> | undefined;
  unidades:Array<unidadeAtendimento> | undefined;

  constructor(private UnidadeService:UnidadesAtendimentoService, private barbeiroService:BarbeirosService){}
  ngOnInit(): void {
      this.barbeiroService.listar().subscribe(barbeiros=>{
        this.barbeiros=barbeiros;
        if(this.barbeiros && this.barbeiros.length > 0){
          this.formulario.get('barbeiroId')?.setValue(this.barbeiros[0].id);
        }
      })
      this.formulario = new FormGroup({
        endereco: new FormControl(null),
        cep: new FormControl(null),
        barbeiroId: new FormControl(null)
      })
      this.formularioBusca = new FormGroup({
        id: new FormControl(null),
        endereco: new FormControl(null),
        cep: new FormControl(null),
      })
      this.formularioListUnidades = new FormGroup({
        id: new FormControl(null),
        endereco: new FormControl(null),
        cep: new FormControl(null),
        barbeiros: new FormControl(null),
      })
      this.formularioExcluir = new FormGroup({
        id: new FormControl(null)
      })
  }
  cadastrarUnidade(): void {
    const unidade: unidadeAtendimento = this.formulario.value;
    const observer: Observer<unidadeAtendimento> = {
      next(_result): void {
        alert('Unidade salva com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
      this.UnidadeService.cadastrar(unidade).subscribe(observer);
  }
  realizarBusca(): void{
    const id: number=this.formularioBusca.get('id').value;
    const observer: Observer<unidadeAtendimento> = {
      next(_result): void {
        alert('Unidade encontrada com sucesso.');
      },
      error(_error): void {
        alert('Erro ao efetuar busca!');
      },
      complete(): void {
      },
    };
    this.UnidadeService.buscar(id).subscribe(observer);
    this.UnidadeService.buscar(id).subscribe(unidade=>{
      this.unidade= unidade;
      this.formularioBusca.get('endereco').setValue(unidade.endereco);
      this.formularioBusca.get('cep').setValue(unidade.cep);
      this.barbeirosBusca=this.unidade.funcionarios;
    })
  }
  listarUnidades(): void {
    i=0;
    this.UnidadeService.listar().subscribe(unidades=>{
      this.unidades = unidades;
      this.unidades.forEach(unidade => {
        this.barbeirosBusca[]set(unidade.funcionarios);
      });
      if(this.unidades && this.unidades.length >0){
        this.formularioListUnidades.get('id').setValue(this.unidades[0].id);
      }
    })
  }
  excluirUnidade(): void {
    const id = this.formularioExcluir.get('id').value;
    const observer: Observer<unidadeAtendimento> = {
      next(_result): void {
        alert('Servico excluido com sucesso.');
      },
      error(_error): void {
        alert('Erro ao excluir!');
      },
      complete(): void {
      },
    };
    this.UnidadeService.excluir(id).subscribe(observer);
  }
}
