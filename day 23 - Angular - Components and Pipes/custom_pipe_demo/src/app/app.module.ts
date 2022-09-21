import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { EmpsaluatationPipe } from './pipes/empsaluatation.pipe';
import { ProductsComponent } from './components/products/products.component';
import { DiscountPipe } from './pipes/discount.pipe';

@NgModule({
  declarations: [
    AppComponent,
    EmpsaluatationPipe,
    ProductsComponent,
    DiscountPipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
