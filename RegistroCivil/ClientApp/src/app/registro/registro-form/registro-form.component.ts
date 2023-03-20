import { Component, Directive, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IRegistro } from '../iregistro';
import { RegistroService } from '../registro.service';


@Component({
  selector: 'app-registro-form',
  templateUrl: './registro-form.component.html',
  styleUrls: ['./registro-form.component.css']
})



export class RegistroFormComponent implements OnInit {

  //constructor con injecciones de servicios
  constructor(private fb: FormBuilder,
    private registroSerices: RegistroService,
    private router: Router,
    private activatedRoute: ActivatedRoute) { }

  //variables
  formGroup!: FormGroup;
  edicionRegistro: boolean = false;
  registroID!: number;
  fechaVal!: Date;

  ngOnInit(): void {

    this.formGroup = this.fb.group({
      numeroIdentificacion: '',
      nombre: '',
      apellido: '',
      sexo: '',
      fechaNacimiento: '',
      hora: '',
      monoparental: false
    });

    this.activatedRoute.params.subscribe(params => {
      if (params["id"] == undefined) {
        //console.log(this.edicionRegistro)

        return;
      } else {
        this.edicionRegistro = true;
        this.registroID = params["id"];
        this.registroSerices.getRegistro(this.registroID.toString())
          .subscribe((registro) => this.cargarFormulario(registro), error => console.error(error));
        //console.log(this.edicionRegistro)

      }
    });
  }

  cargarFormulario(registro: IRegistro) {
    let date = new Date(registro.fechaNacimiento);
    const dateField = date.toISOString().substring(0, 10);
    let h = date.getHours() >= 10 ? date.getHours() : '0' + date.getHours();
    let m = date.getMinutes() >= 10 ? date.getMinutes() : '0' + date.getMinutes();

    this.formGroup.patchValue({
      numeroIdentificacion: registro.numeroIdentificacion,
      nombre: registro.nombre,
      apellido: registro.apellido,
      sexo: registro.sexo,
      fechaNacimiento: dateField,
      hora: h+":"+m,
      monoparental: registro.monoparental
    })
   /* console.log(this.edicionRegistro)
    console.log(date.toISOString().substring(11, 16))
      c this.formGroup.controls['fechaNacimiento'].setValue(date.getFullYear() + '-' + date.getMonth() + '-' + date.getDate());
    this.fechaVal = date.getDate() + "-" + date.getMonth() + "-" + date.getFullYear();
    onsole.table(date.toLocaleDateString())
    console.table(date.getFullYear() + "-" + date.getMonth() + "-" + date.getDate())
 */
  }

  save() {
    
 console.log(this.formGroup.value.fechaNacimiento)
    this.formGroup.value.fechaNacimiento = this.gestionFecha(this.formGroup.value.fechaNacimiento, this.formGroup.value.hora);
    console.log(this.formGroup.value.fechaNacimiento)


    delete this.formGroup.value.hora;
    let registro: IRegistro = Object.assign({}, this.formGroup.value);
    //registro.fechaNacimiento= registro.fechaNacimiento+" "+this.formGroup.value.hora;
    console.table(registro);

    if(this.edicionRegistro){
      //edit
      console.log("editar")
      registro.registroID = this.registroID;
      this.registroSerices.actualizarRegistro(registro)
        .subscribe(() => this.Registrado(), error=> console.error(error));
        return;
    }else{
      //crear
      console.log("Registrar")

      //console.log(registro)
      this.registroSerices.crearRegistro(registro)
      .subscribe(() => this.Registrado(), error => console.error(error))
    }

  }

  Registrado() {
    this.router.navigate(["/registros"]);
  }

  gestionFecha(fecha: string, hora: string): string {

    let auxF: string[] = fecha.split('-')
    let auxH: string[] = hora.split(':')

    let datetime: Date = new Date(parseInt(auxF[0]), parseInt(auxF[1])-1, parseInt(auxF[2]), parseInt(auxH[0])+2, parseInt(auxH[1]))

    return datetime.toJSON();
  }

}
