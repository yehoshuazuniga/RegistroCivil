import { Pipe, PipeTransform } from '@angular/core';
import { IRegistro } from '../registro/iregistro';

@Pipe({
  name: 'tipofamiliafilterdata'
})
export class TipofamiliafilterdataPipe implements PipeTransform {

  transform(registros: IRegistro[], value: string, label: string): IRegistro[] {
    if (!registros) return [];
    if (!value) return registros;
    if (value == null || value=='') return [];

    let valueAux = value == 'true' ? true : false;

    return registros.filter(reg => reg.monoparental == valueAux);
  }

}
