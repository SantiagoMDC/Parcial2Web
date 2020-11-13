import { HttpClient } from '@angular/common/http';
import { Injectable,Inject} from '@angular/core';
import { inject } from '@angular/core/testing';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Vacunas } from '../models/vacunas';

@Injectable({
  providedIn: 'root'
})
export class VacunaService {
  baseUrl: string;
 
  constructor(private http:HttpClient,@Inject('BASE_URL') baseUrl: string,private handleErrorService:HandleHttpErrorService) { this.baseUrl = baseUrl}

  Consultar(): Observable<Vacunas[]>{
    return this.http.get<Vacunas[]>(this.baseUrl + 'api/Vacuna')
    .pipe(
        tap(_ => this.handleErrorService.log('Datos enviados')),
        catchError(this.handleErrorService.handleError<Vacunas[]>('Consulta Vacuna', null))
      );
    
  }

  registrar(Vacunas:Vacunas):Observable<Vacunas>{
    return this.http.post<Vacunas>(this.baseUrl + 'api/Vacuna',Vacunas).pipe(tap(_=> this.handleErrorService.log('Datos enviados')),
      catchError(this.handleErrorService.handleError<Vacunas>('Vacuna Registrada',null)));
  }

  buscarIdentificacion(identificacion:string):Observable<Vacunas>
  {
    return this.http.get<Vacunas>(this.baseUrl + 'api/Vacuna/' + identificacion).pipe(
      catchError(this.handleErrorService.handleError<Vacunas>('Consulta identificacion', null))
    );
  }

  calcularTotal():number{
    let total :number;
    total = 0;

    this.Consultar().forEach(element => {
      total   =  element.length + 1
    });
    return total;
  }
}
