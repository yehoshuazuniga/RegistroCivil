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
  public registrosCoinciden:number=0;


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
      numeroIdentificacion: registro.numeroIdentificacion.substring(0,2),
      nombre: registro.nombre,
      apellido: registro.apellido,
      sexo: registro.sexo,
      fechaNacimiento: dateField,
      hora: h+":"+m,
      monoparental: registro.monoparental
    })
    console.log(this.formGroup.value.numeroIdentificacion)
   /* console.log(this.edicionRegistro)
    console.log(date.toISOString().substring(11, 16))
      c this.formGroup.controls['fechaNacimiento'].setValue(date.getFullYear() + '-' + date.getMonth() + '-' + date.getDate());
    this.fechaVal = date.getDate() + "-" + date.getMonth() + "-" + date.getFullYear();
    onsole.table(date.toLocaleDateString())
    console.table(date.getFullYear() + "-" + date.getMonth() + "-" + date.getDate())
 */
  }

  save() {
    
    this.formGroup.value.fechaNacimiento = this.gestionFecha(this.formGroup.value.fechaNacimiento, this.formGroup.value.hora);
    delete this.formGroup.value.hora;
    this.formGroup.value.numeroIdentificacion = this.gestionNumeroIDentificacion(this.formGroup.value.numeroIdentificacion);

    let registro: IRegistro = Object.assign({}, this.formGroup.value);
    console.log(registro)


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

    console.log(auxF+" "+auxH)
    let datetime: Date = new Date(parseInt(auxF[0]), parseInt(auxF[1])-1, parseInt(auxF[2]), parseInt(auxH[0])+1, parseInt(auxH[1]))
    console.log(datetime.toJSON())

    return datetime.toJSON();
  }
   gestionNumeroIDentificacion(cm:string):string{

    const na1 = Math.floor(Math.random() * 10) ;
    const na2 = Math.floor(Math.random() * 10) ;
    const na3 = Math.floor(Math.random() * 10) ;
    const na4 = Math.floor(Math.random() * 10) ;
    let nIdentificacion = cm +""+na1+""+na2+""+na3+""+na4;

     return nIdentificacion;
  }

}
