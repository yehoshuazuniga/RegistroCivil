import { Component, Directive, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IRegistro } from '../iregistro';
import { RegistroService } from '../registro.service';


@Component({
  selector: 'app-registro-form',
  templateUrl: './registro-form.component.html',
  styleUrls: ['./registro-form.component.css']
})


export class RegistroFormComponent implements OnInit {



  constructor(private fb:FormBuilder, 
    private registroSerices: RegistroService,
    private router:Router) { }
    
  /*   @Input("horaValue")
    public hora?:string; */

    public horaValue?:string;
   
  formGroup!:FormGroup;

  ngOnInit(): void {

    this.formGroup= this.fb.group({
        numeroIdentificacion: '',
        nombre: '',
        apellido: '',
        sexo:'',  
        fechaNacimiento:'',
        monoparental: false
    })

  }

  save(){
   
    let registro:IRegistro = Object.assign({}, this.formGroup.value);

    console.log(this.horaValue);

    return'';
    this.registroSerices.crearRegistro(registro).subscribe(()=>this.Registrado(), error=> console.error(error))
    
  }

  Registrado(){
    this.router.navigate(["/registros"]);
  }

}
