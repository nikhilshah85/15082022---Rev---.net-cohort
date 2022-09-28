import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import { HttpClientModule} from '@angular/common/http';
import { SearchproductComponent } from './components/searchproduct/searchproduct.component'
@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    SearchproductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
