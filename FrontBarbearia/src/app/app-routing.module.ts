import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './components/clientes/clientes.component';
import { BarbeirosComponent } from './components/barbeiros/barbeiros.component';
import { ServicosComponent } from './components/servicos/servicos.component';
import { UnidadesAtendimentoComponent } from './components/unidades-atendimento/unidades-atendimento.component';
const routes: Routes = [
  {path: 'clientes', component:ClientesComponent},
  {path: 'barbeiros', component:BarbeirosComponent},
  {path: 'servicos', component:ServicosComponent},
  {path: 'unidades',component:UnidadesAtendimentoComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
