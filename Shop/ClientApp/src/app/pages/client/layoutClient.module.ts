import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
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
import {OrderComponent} from "./order/order.component";
import {OrderModule} from "./order/order.module";
import { StatisticsComponent } from './statistics/statistics.component';
import {StatisticsModule} from "./statistics/statistics.module";






const clientRoute: Routes = [{
  path: '',
  component: LayoutClientComponent,
  children: [
    {path: 'login', component: LoginComponent},
    {path: 'home', component: HomeComponent},
    {path: 'orders', component: OrdersComponent, canActivate: [AuthGuard]},
    {path: 'order/:id', component: OrderComponent, canActivate: [AuthGuard]},
    {path: 'products', component: ProductsComponent, canActivate: [AuthGuard]},
    {path: 'statistics', component: StatisticsComponent, canActivate: [AuthGuard]},
    {path: 'registration', component: RegistrationComponent},
  ]
}];

@NgModule({
  declarations: [
    LayoutClientComponent,
  ],
  imports: [
    LoginModule,
    StatisticsModule,
    ProductsModule,
    OrdersModule,
    OrderModule,
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
