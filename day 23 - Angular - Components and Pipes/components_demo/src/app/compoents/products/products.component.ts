import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  productList = [
    {pId:101, pName:'Pepsi',pCategory:'Cold-Drink', pPrice:2, pDiscount:5},
    {pId:101, pName:'Pepsi',pCategory:'Cold-Drink', pPrice:2, pDiscount:5},
    {pId:101, pName:'Pepsi',pCategory:'Cold-Drink', pPrice:2, pDiscount:5},
    {pId:101, pName:'Pepsi',pCategory:'Cold-Drink', pPrice:2, pDiscount:5},
    {pId:101, pName:'Pepsi',pCategory:'Cold-Drink', pPrice:2, pDiscount:5}
    ]
  constructor() { }

  ngOnInit(): void {
  }

}
