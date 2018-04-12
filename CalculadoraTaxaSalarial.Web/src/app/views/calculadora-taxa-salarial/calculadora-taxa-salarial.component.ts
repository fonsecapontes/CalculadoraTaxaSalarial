import { Component } from '@angular/core';

@Component({
    selector: 'app-calculadora-taxa-salarial',
    templateUrl: './calculadora-taxa-salarial.component.html',
})
export class CalculadoraTaxaSalarialComponent {
    public title: string;

    constructor() {
        this.title = 'Olá mundo!';
    }
 }
