import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './components/clientes/clientes.component';
import { BarbeirosComponent } from './components/barbeiros/barbeiros.component';
import { ServicosComponent } from './components/servicos/servicos.component';
import { UnidadesAtendimentoComponent } from './components/unidades-atendimento/unidades-atendimento.component';
import { AgendasComponent } from './components/agendas/agendas.component';
import { AtendimentosAvulsoComponent } from './components/atendimentos-avulso/atendimentos-avulso.component';
import { AtendimentosAgendadoComponent } from './components/atendimentos-agendado/atendimentos-agendado.component';
const routes: Routes = [
  {path: 'clientes', component:ClientesComponent},
  {path: 'barbeiros', component:BarbeirosComponent},
  {path: 'servicos', component:ServicosComponent},
  {path: 'unidades',component:UnidadesAtendimentoComponent},
  {path: 'agendas', component:AgendasComponent},
  {path: 'atendimentoavulso', component:AtendimentosAvulsoComponent},
  {path: 'atendimentoagendado', component:AtendimentosAgendadoComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
