import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BarbeirosService } from 'src/app/barbeiros.service';
import { Barbeiro } from 'src/app/Barbeiro';
@Component({
  selector: 'app-barbeiros',
  templateUrl: './barbeiros.component.html',
  styleUrls: ['./barbeiros.component.css']
})
export class BarbeirosComponent implements OnInit{
  formulario:any;
  tituloFormulario: string = '';
  constructor(private barbeirosService: BarbeirosService){}
  ngOnInit(): void {
      this.tituloFormulario= "Novo Barbeiro";
      this.formulario= new FormGroup({
        nome: new FormControl(null),
        cpf: new FormControl(null),
        email: new FormControl(null)
      })
  }
  enviarFormulario(): void {
    const barbeiro : Barbeiro = this.formulario.value;
    this.barbeirosService.cadastrar(barbeiro).subscribe(result=> {
      alert('Barbeiro inserido com sucesso');
    })
  }
}
