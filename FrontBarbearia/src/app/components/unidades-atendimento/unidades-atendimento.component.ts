import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup,FormArray } from '@angular/forms';
import { Observable, Observer } from 'rxjs';
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
  formularioBusca: any;
  formularioListUnidades:any;
  formularioExcluir:any;
  unidade: unidadeAtendimento | undefined;
  unidades:Array<unidadeAtendimento> | undefined;
  constructor(private UnidadeService:UnidadesAtendimentoService, private barbeiroService:BarbeirosService){}
  ngOnInit(): void {
      this.formulario = new FormGroup({
        endereco: new FormControl(null),
        cep: new FormControl(null)
      })
      this.formularioBusca = new FormGroup({
        id: new FormControl(null),
        endereco: new FormControl(null),
        cep: new FormControl(null)
      })
      this.formularioListUnidades = new FormGroup({
        id: new FormControl(null),
        endereco: new FormControl(null),
        cep: new FormControl(null)
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
    };
  realizarBusca(): void {
    const id: any = this.formularioBusca.get('id').value;
  
    const observer: Observer<unidadeAtendimento> = {
      next: (unidade) => {
        alert('Unidade encontrada com sucesso.');
        this.unidade = unidade;
        this.formularioBusca.get('endereco').setValue(unidade.endereco);
        this.formularioBusca.get('cep').setValue(unidade.cep);
      },
      error: (_error) => {
        alert('Erro ao efetuar busca!');
      },
      complete: () => {},
    };
  
    this.UnidadeService.buscar(id).subscribe(observer);
  }
  listarUnidades(): void {
    this.UnidadeService.listar().subscribe(unidades => {
      this.unidades=unidades;
    });
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
