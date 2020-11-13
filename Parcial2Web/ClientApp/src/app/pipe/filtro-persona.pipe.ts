import { Pipe, PipeTransform } from '@angular/core';
import { Vacunas } from '../models/vacunas';

@Pipe({
  name: 'filtroPersona'
})
export class FiltroPersonaPipe implements PipeTransform {

 transform(vacunas: Vacunas[],  searchText: string): any {
  if (searchText === undefined || searchText === '') return vacunas;
    return vacunas.filter(p =>
    p.nombreVacuna.toLowerCase()
  .indexOf(searchText.toLowerCase()) !== -1);
  }


}