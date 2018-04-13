import { NgModule } from '@angular/core';
import { PorcentagemPipe } from './porcentagem.pipe';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CurrencyPipe } from './currency.pipe';


@NgModule({
	declarations: [
		PorcentagemPipe,
		CurrencyPipe,
	],
	exports: [
		PorcentagemPipe,
		CurrencyPipe,
	]
})
export class PipesModule { }
