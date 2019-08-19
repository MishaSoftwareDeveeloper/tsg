import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContentComponent } from './content/content.component';
import { MyheaderComponent } from './myheader/myheader.component';


import { ToolbarModule } from 'primeng/toolbar';
import { ButtonModule } from 'primeng/button';
import { MultiSelectModule } from 'primeng/multiselect';
import { ColorPickerModule } from 'primeng/colorpicker';

@NgModule({
  declarations: [
    AppComponent,
    ContentComponent,
    MyheaderComponent

 
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    ToolbarModule,
    ButtonModule,
    MultiSelectModule,
    ColorPickerModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
