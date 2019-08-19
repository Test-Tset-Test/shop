import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {RouterModule, Routes} from '@angular/router';
import {LayoutClientComponent} from "./layoutClient.component";
import {HomeComponent} from "./home/home.component";
import {HomeModule} from "./home/home.module";
import {NavMenuModule} from "./nav-menu/nav-menu.module";
import {ProductsComponent} from "./products/products.component";
import {ProductsModule} from "./products/products.module";
import {RegistrationModule} from "./registration/registration.module";
import {RegistrationComponent} from "./registration/registration.component";
import {LoginComponent} from "./login/login.component";
import {LoginModule} from "./login/login.module";
import {AuthGuard} from "../../services/authGuardService";
import {OrdersComponent} from "./orders/orders.component";
import {OrdersModule} from "./orders/orders.module";





const clientRoute: Routes = [{
  path: '',
  component: LayoutClientComponent,
  children: [
    {path: 'login', component: LoginComponent},
    {path: 'home', component: HomeComponent},
    {path: 'orders', component: OrdersComponent},
    {path: 'products', component: ProductsComponent, canActivate: [AuthGuard]},
    {path: 'registration', component: RegistrationComponent},
  ]
}];
@NgModule({
  declarations: [
    LayoutClientComponent
  ],
  imports: [
    LoginModule,
    ProductsModule,
    OrdersModule,
    FormsModule,
    HomeModule,
    NavMenuModule,
    RegistrationModule,
    RouterModule.forChild(clientRoute),
  ],
  exports: [
    LayoutClientComponent,
  ],
  providers: [AuthGuard],
})

export class LayoutClientModule {
}
