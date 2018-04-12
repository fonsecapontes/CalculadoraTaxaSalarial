import { Routes } from '@angular/router';
import { CalculadoraTaxaSalarialComponent } from './views/calculadora-taxa-salarial/calculadora-taxa-salarial.component';

export const ROUTES: Routes = [
    { path: 'calculadora-taxa-salarial', component: CalculadoraTaxaSalarialComponent },
    { path: '', redirectTo: 'calculadora-taxa-salarial', pathMatch: 'full' },
    { path: '**', redirectTo: 'calculadora-taxa-salarial' },
];
