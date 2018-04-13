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
        this.funcionarioService.calcularTaxaSalarial(this.model).subscribe(result => {
            debugger;
            this.model = result;
        });
    }
 }
