import { Component, Directive, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { finalize } from 'rxjs';
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
  public formGroup!: FormGroup;
  public edicionRegistro: boolean = false;
  public registroID!: number;
  public fechaVal!: Date;
  public coincidencia: boolean = false;
  public auxString: string = '';
  public auxNumeroIdentificacion: string = '';


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
    this.auxNumeroIdentificacion = registro.numeroIdentificacion;
    this.formGroup.patchValue({
      numeroIdentificacion: registro.numeroIdentificacion.substring(0, 2),
      nombre: registro.nombre,
      apellido: registro.apellido,
      sexo: registro.sexo,
      fechaNacimiento: dateField,
      hora: h + ":" + m,
      monoparental: registro.monoparental
    })
  }

  save() {

    this.formGroup.value.fechaNacimiento = this.gestionFecha(this.formGroup.value.fechaNacimiento, this.formGroup.value.hora);
    delete this.formGroup.value.hora;
    let registro: IRegistro = Object.assign({}, this.formGroup.value);
    registro.numeroIdentificacion = this.auxString;

    if (this.edicionRegistro) {
      //edit
      if ((registro.numeroIdentificacion == '') ||
        (registro.numeroIdentificacion.substring(0, 2) == this.auxNumeroIdentificacion.substring(0, 2))) {
        registro.numeroIdentificacion = this.auxNumeroIdentificacion;
      }
      registro.registroID = this.registroID;

      this.registroSerices.actualizarRegistro(registro)
        .subscribe(() => this.Registrado(), error => console.error(error));
      return;
    } else {
      //crear
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
    // console.log(parseInt(auxH[0]) + 1)
    // console.log(auxF+" "+auxH)
    let datetime: Date = new Date(parseInt(auxF[0]), parseInt(auxF[1]) - 1, parseInt(auxF[2]), parseInt(auxH[0]) + 2, parseInt(auxH[1]))
    //console.log(datetime.getHours()+"*--------------------")
    //console.log(datetime.toJSON())

    return datetime.toJSON();
  }


  gestionNumeroIdentificaion(event: Event) {

    const selectEleemnt = event.target as HTMLElement;

    if (!this.edicionRegistro || event.isTrusted) {

      do {
        this.formGroup.value.numeroIdentificacion = this.generarNumeroIDentificacion(this.formGroup.value.numeroIdentificacion);
      }
      while (this.comprobarNumeroIdentificaion(this.formGroup.value.numeroIdentificacion));

    }

    this.auxString = this.formGroup.value.numeroIdentificacion;

  }

  generarNumeroIDentificacion(cm: string): string {

    let nIdentificacion: string;

    const na1 = Math.floor(Math.random() * 10);
    const na2 = Math.floor(Math.random() * 10);
    const na3 = Math.floor(Math.random() * 10);
    const na4 = Math.floor(Math.random() * 10);
    nIdentificacion = cm + "" + na1 + "" + na2 + "" + na3 + "" + na4;

    return nIdentificacion;
  }

  comprobarNumeroIdentificaion(nIden: string) {


    this.registroSerices.getRegistros().subscribe(responce => {
      if (responce.filter(reg => reg.numeroIdentificacion == nIden).length > 0) {
        this.coincidencia = true;
        console.log(responce.filter(reg => reg.numeroIdentificacion == nIden))
      }
    }, error => console.error(error));

    return this.coincidencia;
  }

  get f() {
    return this.formGroup.controls;
  }

}
