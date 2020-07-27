import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AtmComponent } from './atm/atm.component';
import { AdminComponent } from './admin/admin.component';
import { ClientesService } from '../services/clientes.service';
import { UsuariosOnlineService } from '../services/usuarios-online.service';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    AtmComponent,
    AdminComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'atm', component: AtmComponent },
      { path: 'admin', component: AdminComponent },
      { path: 'login', component: LoginComponent },
    ])
  ],
  providers: [ClientesService, UsuariosOnlineService],
  bootstrap: [AppComponent]
})
export class AppModule { }
