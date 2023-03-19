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



  constructor(private fb: FormBuilder,
    private registroSerices: RegistroService,
    private router: Router) { }

  @Input("horaValue")
  public hora?: string;

  public horaValue?: string;

  formGroup!: FormGroup;

  ngOnInit(): void {

    this.formGroup = this.fb.group({
      numeroIdentificacion: '',
      nombre: '',
      apellido: '',
      sexo: '',
      hora: '',
      fechaNacimiento: '',
      monoparental: false
    })

  }

  save() {
    this.formGroup.value.fechaNacimiento = this.gestionFecha(this.formGroup.value.fechaNacimiento, this.formGroup.value.hora);
    delete this.formGroup.value.hora;
    let registro: IRegistro = Object.assign({}, this.formGroup.value);
    //registro.fechaNacimiento= registro.fechaNacimiento+" "+this.formGroup.value.hora;
    // console.table(registro);

    this.registroSerices.crearRegistro(registro).subscribe(() => this.Registrado(), error => console.error(error))

  }

  Registrado() {
    this.router.navigate(["/registros"]);
  }

  gestionFecha(fecha: string, hora: string): string {

    let auxF: string[] = fecha.split('-')
    let auxH: string[] = hora.split(':')

    let datetime: Date = new Date(parseInt(auxF[0]), parseInt(auxF[1]), parseInt(auxF[2]), parseInt(auxH[0]), parseInt(auxH[1]))

    return datetime.toJSON();
  }

}
