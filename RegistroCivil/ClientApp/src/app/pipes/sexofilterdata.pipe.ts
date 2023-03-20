import { Pipe, PipeTransform } from '@angular/core';
import { IRegistro } from '../registro/iregistro';

@Pipe({
  name: 'sexofilterdata',
  pure:true
})
export class SexofilterdataPipe implements PipeTransform {

  transform(registros:IRegistro[], value:string, label:string): unknown {
    if(!registros) return[];
    if(!value) return registros;
    if(value== null || value=='') return [];

    return registros.filter(reg=> reg.sexo== value);
  }

}
