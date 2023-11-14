import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BarbeirosService } from 'src/app/barbeiros.service';
import { Barbeiro } from 'src/app/Barbeiro';
import { Observer } from 'rxjs';
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
  constructor(private barbeirosService : BarbeirosService) { }

  ngOnInit(): void {
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null)
    })
    this.formularioBusca= new FormGroup({
      id: new FormControl(null),
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null)
    })
    this.formularioListBarbeiros= new FormGroup({
      id: new FormControl(null),
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null)
    })
    this.formularioExcluir= new FormGroup({
      id: new FormControl(null)
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
    const observer: Observer<Barbeiro> = {
      
      next(_result): void {
        alert('Barbeiro encontrado com sucesso.');
      },
      error(_error): void {
        alert('Erro ao procurar!');
      },
      complete(): void {
      },
    };
    this.barbeirosService.buscar(id).subscribe(observer);
    this.barbeirosService.buscar(id).subscribe(barbeiro => {
      const barbeiroTemp: Barbeiro = barbeiro; 
      this.formularioBusca.get('nome').setValue(barbeiroTemp.nome);
      this.formularioBusca.get('cpf').setValue(barbeiroTemp.cpf);
      this.formularioBusca.get('email').setValue(barbeiroTemp.email);
    });
  }
  listarBarbeiros(): void {
    this.barbeirosService.listar().subscribe(barbeiros=>{
      this.barbeiros= barbeiros;
      if(this.barbeiros && this.barbeiros.length >0){
        this.formularioListBarbeiros.get('id').setValue(this.barbeiros[0].barbeiroId);
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
}
