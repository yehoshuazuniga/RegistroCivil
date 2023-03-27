import { Pipe, PipeTransform } from '@angular/core';
import { IRegistro } from '../registro/iregistro';

@Pipe({
  name: 'ccaafilterdata',
  pure:true
})
export class CcaafilterdataPipe implements PipeTransform {

  transform(registros: IRegistro[], value: string, label: string): unknown {
    if (!registros) return [];
    if (!value) return registros;
    if (value == null || value == '') return [];

    return registros.filter(reg => reg.numeroIdentificacion.substring(0,2) == value);
  }

}

