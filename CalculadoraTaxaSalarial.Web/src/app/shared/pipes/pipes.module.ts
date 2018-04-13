import { NgModule } from '@angular/core';
import { PorcentagemPipe } from './porcentagem.pipe';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';


@NgModule({
	declarations: [
		PorcentagemPipe
	],
	exports: [PorcentagemPipe]
})
export class PipesModule { }
