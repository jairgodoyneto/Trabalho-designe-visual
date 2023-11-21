import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Agenda } from 'src/app/Agenda';
import { AgendasService } from 'src/app/agendas.service';
@Component({
  selector: 'app-agendas',
  templateUrl: './agendas.component.html',
  styleUrls: ['./agendas.component.css']
})
export class AgendasComponent implements	OnInit{
  formulario: any;
  ngOnInit(): void {
    this.formulario = new FormGroup({
      placa: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
}
