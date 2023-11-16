import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ClientesService } from 'src/app/clientes.service';
import { Cliente } from 'src/app/Cliente';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {
  formulario: any;
  clientes: Array<Cliente> | undefined;
  formularioBusca:any;
  formularioListClientes:any;
  formularioExcluir:any;
  constructor(private clientesService : ClientesService) { }

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
    this.formularioListClientes= new FormGroup({
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
    const cliente : Cliente = this.formulario.value;
    const observer: Observer<Cliente> = {
      next(_result): void {
        alert('Cliente salvo com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
    this.clientesService.cadastrar(cliente).subscribe(observer);
  }
  realizarBusca(): void {
    const id = this.formularioBusca.get('id').value;
    const observer: Observer<Cliente> = {
      next(_result): void {
        alert('Cliente encontrado.');
      },
      error(_error): void {
        alert('Erro ao procurar!');
      },
      complete(): void {
      },
    };
    this.clientesService.buscar(id).subscribe(observer => {
      const clienteTemp: Cliente = observer;
      this.formularioBusca.get('nome').setValue(clienteTemp.nome);
      this.formularioBusca.get('cpf').setValue(clienteTemp.cpf);
      this.formularioBusca.get('email').setValue(clienteTemp.email);
    });
  }
  listarCLientes(): void {
    this.clientesService.listar().subscribe(clientes=>{
      this.clientes= clientes;
      if(this.clientes && this.clientes.length >0){
        this.formularioListClientes.get('id').setValue(this.clientes[0].id);
      }
    })
  }
  excluirCliente(): void {
    const id = this.formularioExcluir.get('id').value;
    const observer: Observer<Cliente> = {
      next(_result): void {
        alert('Cliente excluido com sucesso.');
      },
      error(_error): void {
        alert('Erro ao excluir!');
      },
      complete(): void {
      },
    };
    this.clientesService.excluir(id).subscribe(observer);
  }
}
