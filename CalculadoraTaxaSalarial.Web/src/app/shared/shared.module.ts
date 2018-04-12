import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { PipesModule } from './pipes/pipes.module';
import { ServicesModule } from './services/services.module';

@NgModule({
	exports: [
		CommonModule,
		FormsModule,
        ReactiveFormsModule,
        ServicesModule,
        PipesModule,
	],
	imports: [
		CommonModule,
		FormsModule,
        ReactiveFormsModule,
        ServicesModule,
        PipesModule,
	]
})
export class SharedModule { }
