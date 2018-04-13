import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import FuncionarioModel from '../models/funcionario.model';

@Injectable()
export class FuncionarioService {
    private readonly service: string = 'CalcularTaxaSalarial';

	constructor(private readonly httpService: HttpService) { }

	calcularTaxaSalarial(funcionario: FuncionarioModel): any {
		return this.httpService.post(this.service, funcionario);
	}
}
