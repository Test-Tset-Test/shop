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





const clientRoute: Routes = [{
  path: '',
  component: LayoutClientComponent,
  children: [
    {path: 'home', component: HomeComponent},
    {path: 'products', component: ProductsComponent},
    {path: 'registration', component: RegistrationComponent},
  ]
}];
@NgModule({
  declarations: [
    LayoutClientComponent
  ],
  imports: [
    ProductsModule,
    FormsModule,
    HomeModule,
    NavMenuModule,
    RegistrationModule,
    RouterModule.forChild(clientRoute),
  ],
  exports: [
    LayoutClientComponent,
  ],
  providers: []
})

export class LayoutClientModule {
}
