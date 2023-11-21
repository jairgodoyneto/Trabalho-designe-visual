import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BarbeirosService } from 'src/app/barbeiros.service';
import { Barbeiro } from 'src/app/Barbeiro';
import { Observable, Observer } from 'rxjs';
import { UnidadesAtendimentoService } from 'src/app/unidades-atendimento.service';
import { unidadeAtendimento } from 'src/app/unidadeAtendimento';
@Component({
  selector: 'app-barbeiros',
  templateUrl: './barbeiros.component.html',
  styleUrls: ['./barbeiros.component.css']
})
export class BarbeirosComponent implements OnInit {
  formulario: any;
  barbeiros: Array<Barbeiro> | undefined;
  formularioBusca:any;
  formularioListBarbeiros:any;
  formularioExcluir:any;
  formularioAlterar:any;
  constructor(private barbeirosService : BarbeirosService, private unidadeService:UnidadesAtendimentoService) { }

  ngOnInit(): void {
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      unidadeId: new FormControl(null)
    })
    this.formularioBusca= new FormGroup({
      id: new FormControl(null),
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      endereco: new FormControl(null)
    })
    this.formularioListBarbeiros= new FormGroup({
      id: new FormControl(null),
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      endereco: new FormControl(null)
    })
    this.formularioExcluir= new FormGroup({
      id: new FormControl(null)
    })
    this.formularioAlterar= new FormGroup({
      id: new FormControl(null),
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      unidadeId: new FormControl(null)
    })
  }
  enviarCadastro(): void {
    const barbeiro : Barbeiro = this.formulario.value;
    const observer: Observer<Barbeiro> = {
      next(_result): void {
        alert('Barbeiro salvo com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
    this.barbeirosService.cadastrar(barbeiro).subscribe(observer);
  }
  realizarBusca(): void {
    const id = this.formularioBusca.get('id').value;
  
    const barbeiro: Observer<Barbeiro> = {
      next: (barbeiro: Barbeiro) => {
        alert('Barbeiro encontrado com sucesso.');
        
        // Atualiza os campos do formulário com os dados do barbeiro
        this.formularioBusca.get('nome').setValue(barbeiro.nome);
        this.formularioBusca.get('cpf').setValue(barbeiro.cpf);
        this.formularioBusca.get('email').setValue(barbeiro.email);
        
        // Busca a unidade de atendimento e atualiza o campo de endereço
        this.unidadeService.buscar(barbeiro.unidadeId).subscribe(
          (unidade: unidadeAtendimento) => {
            this.formularioBusca.get('endereco').setValue(unidade.endereco);
          },
          (error: any) => {
            console.error('Erro ao buscar unidade:', error);
          }
        );
      },
      error: (error: any) => {
        alert('Erro ao procurar barbeiro!');
        console.error('Erro ao buscar barbeiro:', error);
      },
      complete: () => {
        // Executa ações quando a operação estiver completa, se necessário
      },
    };
  
    // Chama o serviço para buscar o barbeiro
    this.barbeirosService.buscar(id).subscribe(barbeiro);
  }
  listarBarbeiros(): void {
    this.barbeirosService.listar().subscribe(barbeiros=>{
      this.barbeiros= barbeiros;
      if(this.barbeiros && this.barbeiros.length >0){
        this.formularioListBarbeiros.get('id').setValue(this.barbeiros[0].id);
      }
    })
  }
  excluirBarbeiro(): void {
    const id = this.formularioExcluir.get('id').value;
    const observer: Observer<Barbeiro> = {
      next(_result): void {
        alert('Barbeiro excluido com sucesso.');
      },
      error(_error): void {
        alert('Erro ao excluir!');
      },
      complete(): void {
      },
    };
    this.barbeirosService.excluir(id).subscribe(observer);
  }
  Alterar(): void{
    const barbeiro:Barbeiro = this.formularioAlterar.value;
    const observer: Observer<Barbeiro> = {
      next(_result): void {
        alert('Barbeiro alterado com sucesso.');
      },
      error(_error): void {
        alert('Erro ao alterar!');
      },
      complete(): void {
      },
    };
    this.barbeirosService.atualizar(barbeiro).subscribe(observer);
  }
}
