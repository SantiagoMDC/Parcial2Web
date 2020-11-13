import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonaRegisterComponent } from './Parcial2/persona-register/persona-register.component';
import { PersonaConsultaComponent } from './Parcial2/persona-consulta/persona-consulta.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'personaRegister',
    component:PersonaRegisterComponent
  },
  {
    path: 'personaConsulta',
    component:PersonaConsultaComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)

  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
