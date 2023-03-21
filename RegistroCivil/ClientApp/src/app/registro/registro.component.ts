import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
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
  public gestionAscDesc: boolean = true;

  constructor(private registroServices: RegistroService) { }

  ngOnInit(): void {

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
    //console.log(this.queryOrden)

 //   console.log(campo)
    if (campo != this.queryOrden) {
      this.queryOrden = campo;
      this.gestionAscDesc=false;
    } else {
      this.gestionAscDesc = !this.gestionAscDesc;
      //console.log(this.gestionAscDesc)

    }
  }

  gestionIcono(event:MouseEvent):void{
    
    const spanEleemnt = event.target as HTMLElement;

    if (spanEleemnt.className =='bi bi-sort-down'){
      spanEleemnt.className = 'bi bi-sort-up';
    }else{
      if (spanEleemnt.className == 'bi bi-sort-up'){
        spanEleemnt.className = 'bi bi-sort-down'
      }
    }



  }



}
