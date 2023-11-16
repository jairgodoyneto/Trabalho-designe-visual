import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ServicosService } from 'src/app/servicos.service';
import { Servico } from 'src/app/Servico';
import { Observer } from 'rxjs';
@Component({
  selector: 'app-servicos',
  templateUrl: './servicos.component.html',
  styleUrls: ['./servicos.component.css']
})
export class ServicosComponent implements OnInit {
  formulario:any;
  formularioBusca:any;
  formularioListServicos: any;
  formularioExcluir: any;
  servicos : Array<Servico> | undefined;
  constructor(private servicosService: ServicosService){}
  ngOnInit(): void {
    this.formulario = new FormGroup({
      nome : new FormControl(null),
      descricao: new FormControl(null),
      custo : new FormControl(null),
      duracao: new FormControl(null)
    })  
    this.formularioBusca = new FormGroup({
      id : new FormControl(null),
      nome : new FormControl(null),
      descricao: new FormControl(null),
      custo : new FormControl(null),
      duracao: new FormControl(null)
    })
    this.formularioListServicos = new FormGroup({
      id : new FormControl(null),
      nome : new FormControl(null),
      descricao: new FormControl(null),
      custo : new FormControl(null),
      duracao: new FormControl(null)
    })
    this.formularioExcluir = new FormGroup({
      id: new FormControl(null)
    })
  }
  enviarCadastro(): void {
    const servico : Servico = this.formulario.value;
    const observer: Observer<Servico> = {
      next(_result): void {
        alert('Servico salvo com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
    this.servicosService.cadastrar(servico).subscribe(observer);
  }
  realizarBusca(): void {
    const id = this.formularioBusca.get('id').value;
    const observer: Observer<Servico> = {
      next(_result): void {
        alert('Servico encontrado.');
      },
      error(_error): void {
        alert('Erro ao procurar!');
      },
      complete(): void {
      },
    };
    this.servicosService.buscar(id).subscribe(observer => {
      const servicoTemp: Servico = observer;
      this.formularioBusca.get('nome').setValue(servicoTemp.nome);
      this.formularioBusca.get('descricao').setValue(servicoTemp.descricao);
      this.formularioBusca.get('custo').setValue(servicoTemp.custo);
      this.formularioBusca.get('duracao').setValue(servicoTemp.duracao)
    });
  }
  listarServicos(): void {
    this.servicosService.listar().subscribe(servicos=>{
      this.servicos = servicos;
      if(this.servicos && this.servicos.length >0){
        this.formularioListServicos.get('id').setValue(this.servicos[0].id);
      }
    })
  }
  excluirServico(): void {
    const id = this.formularioExcluir.get('id').value;
    const observer: Observer<Servico> = {
      next(_result): void {
        alert('Servico excluido com sucesso.');
      },
      error(_error): void {
        alert('Erro ao excluir!');
      },
      complete(): void {
      },
    };
    this.servicosService.excluir(id).subscribe(observer);
  }
}
