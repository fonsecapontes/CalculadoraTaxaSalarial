import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'currency' })
export class CurrencyPipe implements PipeTransform {
    transform(value: any, args?: any): any {
        if (!value) { return value; }
        return 'R$ ' + value.toFixed(2).replace('.', ',').replace(/(\d)(?=(\d{3})+\,)/g, '$1.');
    }
}
