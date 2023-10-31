import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './components/clientes/clientes.component';
import { BarbeirosComponent } from './components/barbeiros/barbeiros.component';
const routes: Routes = [
  {path: 'clientes', component:ClientesComponent},
  {path: 'barbeiros', component:BarbeirosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
