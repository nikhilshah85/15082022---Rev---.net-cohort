import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {


    productList = [
      {pId:101, pName:'Pepsi Rack', pCategory:'Cold-Drink', pPrice:20},
      {pId:102, pName:'IPhone', pCategory:'Electronics', pPrice:1850},
      {pId:103, pName:'Airpods', pCategory:'Electronics', pPrice:700},
      {pId:104, pName:'Nike Shoes', pCategory:'Accessories', pPrice:850},
      {pId:105, pName:'T-Shirt', pCategory:'Accessories', pPrice:150},
      {pId:106, pName:'Microsoft Surface', pCategory:'Electronics', pPrice:2450},
      {pId:107, pName:'Blackberry T19', pCategory:'Electronics', pPrice:1400},
      {pId:108, pName:'Apple TV', pCategory:'Electronics', pPrice:950},
    ]

  constructor() { }

  ngOnInit(): void {
  }

}
