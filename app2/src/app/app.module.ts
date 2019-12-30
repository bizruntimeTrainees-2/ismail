import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PipesComponent } from './pipes/pipes.component';
import { ServicesComponent } from './services/services.component';
import { NgifForSwitchComponent } from './ngif-for-switch/ngif-for-switch.component';
import { ComponentInteractionComponent } from './component-interaction/component-interaction.component';

@NgModule({
  declarations: [
    AppComponent,
    PipesComponent,
    ServicesComponent,
    NgifForSwitchComponent,
    ComponentInteractionComponent,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
