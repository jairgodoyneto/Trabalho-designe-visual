import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ClientesService } from 'src/app/clientes.service';
import { Cliente } from 'src/app/Cliente';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  id:number=0;
  constructor(private clientesService : ClientesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Cliente';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null)
    })
  }
  enviarCadastro(): void {
    const cliente : Cliente = this.formulario.value;
    this.clientesService.cadastrar(cliente).subscribe(result => {
      alert('Cliente inserido com sucesso.');
    })
  }
  enviarBusca(): void {
    this.clientesService.buscar(this.id).subscribe(result => {
      alert("busca funcionou")
    })
  } 
}
