import { NgModule } from '@angular/core';
import {MatButtonModule, MatButtonToggleModule,
  MatProgressSpinnerModule
} from '@angular/material'

const MaterialComponents = [
  MatButtonModule,
  MatButtonToggleModule,
  MatProgressSpinnerModule
]

@NgModule({
  imports: [MaterialComponents  ],
  exports:[MaterialComponents]
})
export class MaterailModule { }
