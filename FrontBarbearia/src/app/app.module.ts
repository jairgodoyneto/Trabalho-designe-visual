import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http'; 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule} from 'ngx-bootstrap/modal';

import {ClientesService} from './clientes.service';
import {ClientesComponent} from './components/clientes/clientes.component';

import {BarbeirosService} from './barbeiros.service';
import {BarbeirosComponent} from './components/barbeiros/barbeiros.component';

import {ServicosService} from './servicos.service';
import {ServicosComponent} from './components/servicos/servicos.component';

import { UnidadesAtendimentoService } from './unidades-atendimento.service';
import { UnidadesAtendimentoComponent } from './components/unidades-atendimento/unidades-atendimento.component';

import { AgendasService } from './agendas.service';
import { AtendimentosAgendadoService } from './atendimentos-agendado.service';
import { AtendimentosAvulsoService } from './atendimentos-avulso.service';
import { AgendasComponent } from './components/agendas/agendas.component';
import { AtendimentosAvulsoComponent } from './components/atendimentos-avulso/atendimentos-avulso.component';
import { AtendimentosAgendadoComponent } from './components/atendimentos-agendado/atendimentos-agendado.component';
import { InicioComponent } from './components/inicio/inicio.component';
@NgModule({
  declarations: [
    AppComponent,
    ClientesComponent,
    BarbeirosComponent,
    ServicosComponent,
    UnidadesAtendimentoComponent,
    AgendasComponent,
    AtendimentosAvulsoComponent,
    AtendimentosAgendadoComponent,
    InicioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [HttpClientModule, ClientesService,BarbeirosService,ServicosService,
    UnidadesAtendimentoService,AtendimentosAvulsoService,AtendimentosAgendadoService,AgendasService],
  bootstrap: [AppComponent]
})
export class AppModule { }