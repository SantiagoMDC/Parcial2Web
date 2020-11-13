import { Component, OnInit } from '@angular/core';
import { Persona } from 'src/app/models/persona';
import {Vacunas} from 'src/app/models/vacunas';
import {VacunaService} from 'src/app/services/vacuna.service'
import { PersonaService } from 'src/app/services/persona.service';
import { FormGroup, FormBuilder, Validators, AbstractControl} from '@angular/forms';

@Component({
  selector: 'app-persona-register',
  templateUrl: './persona-register.component.html',
  styleUrls: ['./persona-register.component.css']
})
export class PersonaRegisterComponent implements OnInit {

  formRegister: FormGroup;
  submitted = false;
  persona : Persona;
  constructor(private service:PersonaService,private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.persona = new Persona;
    this.buildForm();

  }
  private buildForm() {
        this.persona = new Persona();
        this.persona.tipoDeDocumento = '';
        this.persona.identificacion = '';
        this.persona.nombre = '';
        this.persona.fechaDeNacimiento;
        this.persona.institucionEducativa='';
        this.persona.nombreAcudiente;

        this.formRegister= this.formBuilder.group({
          tipoDeDocumento: [this.persona.tipoDeDocumento, Validators.required],
          identificacion: [this.persona.identificacion, Validators.required],
          nombre: [this.persona.nombre, Validators.required],
          fechaDeNacimiento: [this.persona.fechaDeNacimiento, Validators.required],
          institucionEducativa: [this.persona.institucionEducativa, Validators.required],
          nombreAcudiente: [this.persona.nombreAcudiente, Validators.required]
        });
      }
    
  get f() { 
    return this.formRegister.controls;
  }
  add() {
    this.persona = this.formRegister.value;
    this.service.registrar(this.persona).subscribe(p => {
      if (p != null) {
        this.onReset();
        alert('Guardado con exito');
      }
    })
  }
  
  

  onSubmit() {
   if (this.formRegister.invalid) {
      return;
    }
   this.add();
  }
        
  get(){
    this.service.buscarIdentificacion(this.persona.identificacion).subscribe(result => {
      this.persona = result;
    });
  }
  onReset() {
    this.submitted = false;
    this.formRegister.reset();
  }
}
