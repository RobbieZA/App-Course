import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { HttpClient } from 'selenium-webdriver/http';
import { HttpModule } from '@angular/http';


@NgModule({
  declarations: [
    AppComponent,
    ValueComponent
],
  imports: [
    BrowserModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
