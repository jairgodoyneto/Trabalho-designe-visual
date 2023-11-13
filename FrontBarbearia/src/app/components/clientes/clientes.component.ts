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
  tituloFormulario: string = '';
  formularioBusca:any;
  cliente = new Cliente();
  constructor(private clientesService : ClientesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Cliente';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null)
    })
    this.formularioBusca= new FormGroup({
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
  }
  realizarBusca(): void {
    const id : number = this.formularioBusca.value;
    this.clientesService.buscar(id).subscribe(cliente => {
      
    })
  } 
}
