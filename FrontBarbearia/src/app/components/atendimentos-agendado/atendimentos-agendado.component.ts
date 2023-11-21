import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { AtendimentoAgendado } from 'src/app/AtendimentoAgendado';
import { AtendimentosAgendadoService } from 'src/app/atendimentos-agendado.service';
@Component({
  selector: 'app-atendimentos-agendado',
  templateUrl: './atendimentos-agendado.component.html',
  styleUrls: ['./atendimentos-agendado.component.css']
})
export class AtendimentosAgendadoComponent implements	OnInit{
  formulario: any;
  ngOnInit(): void {
    this.formulario = new FormGroup({
      placa: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
}
