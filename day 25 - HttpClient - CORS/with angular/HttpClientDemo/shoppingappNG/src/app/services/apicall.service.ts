import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApicallService {

  
  _http:HttpClient;
  products:any;
  oneProduct:any;

  constructor(_httpREF:HttpClient) {
    this._http = _httpREF;
   }

   getProductsData()
   {
      return this._http.get('https://localhost:7278/api/Products').subscribe(result => {
        this.products = result;
      });
   }

   searchProduct(productId:number)
   {
  let url = "https://localhost:7278/api/Products/" + productId
      return this._http.get(url).subscribe( prod => {
        this.oneProduct = prod;
      })
   }


}
