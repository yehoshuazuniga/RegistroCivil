import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { IRegistro } from './iregistro';
import { RegistroService } from './registro.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {

  public registros: IRegistro[] = [];
  public paginaActual: number = 1;
  public query: string = '';
  public queryOrden: string = 'registroID';
  public queryFilterSexo: string = '';
  public queryFilterCCAA: string = '';
  public queryTipoFamilia: string='' ;
  public gestionAscDesc: boolean = true;
  public comunidadAutonoma!: string;
  public radioGroup!: FormGroup;
  public diccionarioCCAA = {
    "AN": "Andalucía ",
    "AR": "Aragón ",
    "AS": "Asturias ",
    "IB": "Baleares ",
    "CN": "Canarias ",
    "CB": "Cantabria ",
    "CM": "Castilla - La Mancha ",
    "CL": "Castilla y León ",
    "CT": "Cataluña ",
    "CE": "Ceuta ",
    "VC": "Comunidad Valenciana ",
    "EX": "Extremadura ",
    "GA": "Galicia ",
    "MD": "Madrid ",
    "ML": "Melilla ",
    "MU": "Murcia ",
    "NA": "Navarra ",
    "PV": "País Vasco ",
    "RI": "La Rioja "
  }


  constructor(private registroServices: RegistroService) { }

  ngOnInit(): void {

    //this.serviceNav.isShow=true;
    this.cargarRegistros();
  }

  borrar(registro: IRegistro) {
    this.registroServices.eliminarRegistro(registro.registroID.toString())
      .subscribe(() => this.cargarRegistros(), error => console.log(error));

  }

  cargarRegistros() {
    this.registroServices.getRegistros().subscribe(registros => this.registros = registros, error => console.error(error))
  }

  orderWay(campo: string) {

    if (campo != this.queryOrden) {
      this.queryOrden = campo;
      this.gestionAscDesc = false;
    } else {
      this.gestionAscDesc = !this.gestionAscDesc;
      //console.log(this.gestionAscDesc)

    }
  }

  gestionIcono(event: MouseEvent): void {

    const spanEleemnt = event.target as HTMLElement;

    if (spanEleemnt.className == 'bi bi-sort-down') {
      spanEleemnt.className = 'bi bi-sort-up';
    } else {
      if (spanEleemnt.className == 'bi bi-sort-up') {
        spanEleemnt.className = 'bi bi-sort-down'
      }
    }
  }


  buscarCCAA(cod:string):string{
    let aux2='';
    for (const [key, value] of Object.entries(this.diccionarioCCAA)) {
      if (key.toString() == cod.substring(0, 2)) {
        aux2 = value.toString();

      }

    }
    return aux2; 
   }
}