import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { RegistroComponent } from './registro/registro.component';
import { RegistroService } from './registro/registro.service';
import { RegistroFormComponent } from './registro/registro-form/registro-form.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { FilterdataPipe } from './pipes/filterdata.pipe';
import { OrderModule } from 'ngx-order-pipe';
import { SexofilterdataPipe } from './pipes/sexofilterdata.pipe';

@NgModule({
  declarations: [
    AppComponent,RegistroComponent, RegistroFormComponent,
    NavMenuComponent, HomeComponent, CounterComponent,
    FetchDataComponent, FilterdataPipe, SexofilterdataPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,ReactiveFormsModule,
    FormsModule, NgxPaginationModule, 
    OrderModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'registros', component: RegistroComponent },
      { path: 'add-registro', component: RegistroFormComponent },
      { path: 'add-registro', component: RegistroFormComponent },
      { path: 'registro-edit/:id', component: RegistroFormComponent }
    ])
  ],
  providers: [RegistroService],
  bootstrap: [AppComponent]
})
export class AppModule { }
