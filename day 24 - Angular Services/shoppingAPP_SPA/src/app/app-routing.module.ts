import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './Components/about/about.component';
import { ContactComponent } from './Components/contact/contact.component';
import { CustomersComponent } from './Components/customers/customers.component';
import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/login/login.component';
import { OrdersComponent } from './Components/orders/orders.component';
import { ProductsComponent } from './Components/products/products.component';

const routes: Routes = [
  { path:'home',component:HomeComponent },
  { path:'about', component:AboutComponent},
  { path:'contact', component:ContactComponent},
  { path:'products', component:ProductsComponent},
  { path:'orders', component:OrdersComponent},
  { path:'customer', component:CustomersComponent},
  { path:'login', component:LoginComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
