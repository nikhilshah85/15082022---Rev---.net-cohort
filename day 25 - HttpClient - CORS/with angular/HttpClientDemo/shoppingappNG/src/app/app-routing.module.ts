import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from './components/products/products.component';
import { SearchproductComponent } from './components/searchproduct/searchproduct.component';

const routes: Routes = [
  {path:'plist', component:ProductsComponent},
  {path:'searchp', component:SearchproductComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
