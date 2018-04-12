import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SharedModule } from '../../shared/shared.module';
import { CalculadoraTaxaSalarialComponent } from './calculadora-taxa-salarial.component';

const routes: Routes = [
	{ path: '', component: CalculadoraTaxaSalarialComponent }
];

@NgModule({
	declarations: [CalculadoraTaxaSalarialComponent],
	imports: [RouterModule.forChild(routes), SharedModule]
})
export class FormModule { }
