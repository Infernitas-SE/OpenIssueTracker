import { NgModule } from '@angular/core';
import { BrowserModule, Title } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SecurityService } from './services/security/security-service.service';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { CookieService } from 'ngx-cookie-service';

/* Material Design for Bootstrap - Angular */
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FooterComponent } from './components/footer/footer.component';
import { LoginComponent } from './views/login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CommonModule,
    MDBBootstrapModule.forRoot(),
    HttpClientModule
  ],
  providers: [Title, SecurityService, CookieService],
  bootstrap: [AppComponent],
  exports: []
})
export class AppModule { }
