import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HttpClientModule} from '@angular/common/http';

import {LayoutClientComponent} from './pages/client/layoutClient.component';
import {LayoutClientModule} from './pages/client/layoutClient.module';
import {AppComponent} from "./components/app/app.component";
import {ProductsApiService} from "./api/product.api.service";
import {BaseApiService} from "./api/base.api.service";
import {AuthApiService} from "./api/auth.api.service";
import {AuthService} from "./services/auth.service";


const appRoutes: Routes = [
  {path: '', component: LayoutClientComponent},
  // {path: '**', redirectTo: 'auth/login'},
];

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    LayoutClientModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
  ],
  providers: [AuthService, AuthApiService, BaseApiService, ProductsApiService,],
  bootstrap: [AppComponent]
})
export class AppModule {
}
