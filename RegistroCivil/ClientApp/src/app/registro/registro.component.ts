import { Component, OnInit, SimpleChange } from '@angular/core';
import { IRegistro } from './iregistro';
import { RegistroService } from './registro.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {

  public registros: IRegistro[]=[];
  public paginaActual:number=1;
  public query:string='';
  public queryOrden: string = 'registroID';
  public queryFilterSexo:string='';

  constructor(private registroServices:RegistroService ) { }

  ngOnInit(): void {

   this.cargarRegistros();
  }

  borrar(registro:IRegistro){
    this.registroServices.eliminarRegistro(registro.registroID.toString())
    .subscribe(()=>this.cargarRegistros(), error=>console.log(error));
    
  }

  cargarRegistros(){
     this.registroServices.getRegistros().subscribe(registros => this.registros = registros, error=>console.error(error))
  }

  orderWay(tipo:string){
    console.log('funciono')
    this.queryOrden = tipo 
    console.log(this.queryOrden)

  }

}
