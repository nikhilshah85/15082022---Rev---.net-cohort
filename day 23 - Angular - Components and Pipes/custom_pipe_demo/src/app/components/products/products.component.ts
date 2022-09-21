import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {


    pList = [
      {pId:101,pName:'Pepsi',pPrice:100,pCategory:'Drink'},
      {pId:102,pName:'Iphone',pPrice:100,pCategory:'Electronics'},
      {pId:103,pName:'AirPods',pPrice:100,pCategory:'Electronics'},
      {pId:104,pName:'Burger',pPrice:100,pCategory:'Fast-Food'},
      {pId:105,pName:'Noodles',pPrice:100,pCategory:'Fast-Food'},
      {pId:106,pName:'TShirt',pPrice:100,pCategory:'Cloths'},
      {pId:107,pName:'Green-Tea',pPrice:100,pCategory:'Drink'},
    ]


  constructor() { }

  ngOnInit(): void {
  }

}
