import { Component, OnInit } from '@angular/core';
import { Vacunas } from 'src/app/models/vacunas';
import { VacunaService } from 'src/app/services/vacuna.service';


@Component({
  selector: 'app-persona-consulta',
  templateUrl: './persona-consulta.component.html',
  styleUrls: ['./persona-consulta.component.css']
})
export class PersonaConsultaComponent implements OnInit {

  vacunas:Vacunas[];
  Total :Number;
  searchText = "";
  searchText1 = "";
  constructor(private service:VacunaService) { }

  ngOnInit(): void {
    this.get();
    this.Totale();
    this.Total
  }
  get(){
    this.service.Consultar().subscribe(result => {
      this.vacunas = result;
    });

  }
  Totale(){
    this.Total = this.service.calcularTotal();

  }
  
}
