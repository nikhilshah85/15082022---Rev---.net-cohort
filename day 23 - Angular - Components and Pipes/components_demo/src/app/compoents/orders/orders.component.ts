import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {

  orderDetails = {
    oId:101, oValue:200, oDate:'10-Jan-2022',oLocation:'NYK',oProduct:'T-shirt'
    }
  constructor() { }

  ngOnInit(): void {
  }

}
