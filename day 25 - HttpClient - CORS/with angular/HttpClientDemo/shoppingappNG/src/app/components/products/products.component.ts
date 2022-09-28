import { Component, OnInit } from '@angular/core';
import { ApicallService } from 'src/app/services/apicall.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  _makeApiCall:ApicallService;

  constructor(_apicallREF:ApicallService) {
    this._makeApiCall = _apicallREF;
   }

  ngOnInit(): void {
  }

}
