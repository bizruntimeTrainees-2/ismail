import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { TreeModule } from 'angular-tree-component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FulltreeComponent } from './fulltree/fulltree.component';
import { ApiComponent } from './api/api.component';

@NgModule({
  declarations: [
    AppComponent,
    FulltreeComponent,
    ApiComponent
  ],
  imports: [
    BrowserModule,
    TreeModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
