import { Component } from '@angular/core';
import FuncionarioModel from '../../shared/models/funcionario.model';
import { FuncionarioService } from '../../shared/services/funcionario.service';

@Component({
    selector: 'app-calculadora-taxa-salarial',
    templateUrl: './calculadora-taxa-salarial.component.html',
})
export class CalculadoraTaxaSalarialComponent {
    public model: FuncionarioModel = new FuncionarioModel();

    constructor(private readonly funcionarioService: FuncionarioService) {}

    public calcular() {

        this.model.salarioLiquido = null;
        this.model.porcentagemImposto = null;
        this.model.valorImpostoPago = 0;

        this.funcionarioService.calcularTaxaSalarial(this.model).subscribe(result => {
            this.model = result;
        });
    }
 }
