import { NgModule } from '@angular/core';
import {MatButtonModule, MatButtonToggleModule,
  MatProgressSpinnerModule,MatSidenavModule,MatToolbarModule,
  MatMenuModule
  
} from '@angular/material'

const MaterialComponents = [
  MatButtonModule,
  MatButtonToggleModule,
  MatProgressSpinnerModule,
  MatSidenavModule,
  MatToolbarModule,
  MatMenuModule
]

@NgModule({
  imports: [MaterialComponents  ],
  exports:[MaterialComponents]
})
export class MaterailModule { }
