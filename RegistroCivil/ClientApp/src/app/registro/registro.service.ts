import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IRegistro } from './iregistro';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {
  private apiURL: string = "";

  constructor(private http: HttpClient) {

  }

  getRegistros(): Observable<IRegistro[]> {
    this.apiURL = "https://localhost:7216/api/Registros";
    return this.http.get<IRegistro[]>(this.apiURL);
  }

  getRegistro(registroID: string): Observable<IRegistro> {
    this.apiURL = "https://localhost:7216/api/Registros";
    return this.http.get<IRegistro>(this.apiURL + '/' + registroID);
  }

  actualizarRegistro(registro: IRegistro): Observable<IRegistro> {
    this.apiURL = "https://localhost:7216/api/Registros";
    return this.http.put<IRegistro>(this.apiURL + '/' + registro.registroID.toString(), registro);
  }

  crearRegistro(registro: IRegistro): Observable<IRegistro> {
    this.apiURL = "https://localhost:7216/api/Registros";
    return this.http.post<IRegistro>(this.apiURL, <IRegistro>registro);
  }

  eliminarRegistro(id: string): Observable<IRegistro> {
    this.apiURL = "https://localhost:7216/api/Registros";
    return this.http.delete<IRegistro>(this.apiURL + '/' + id);
  }


}
