import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';

import { HttpService } from './http.service';
import { FuncionarioService } from './funcionario.service';

@NgModule({
	imports: [
		HttpClientModule,
	],
	providers: [
		FuncionarioService,
		HttpService,
	]
})
export class ServicesModule { }
