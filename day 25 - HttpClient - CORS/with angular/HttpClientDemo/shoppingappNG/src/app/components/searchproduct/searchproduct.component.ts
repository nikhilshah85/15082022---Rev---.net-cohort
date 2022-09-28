import { Component, OnInit } from '@angular/core';
import { ApicallService } from 'src/app/services/apicall.service';

@Component({
  selector: 'app-searchproduct',
  templateUrl: './searchproduct.component.html',
  styleUrls: ['./searchproduct.component.css']
})
export class SearchproductComponent implements OnInit {


  
  _makeApiCall:ApicallService;

  constructor(_apicallREF:ApicallService) {
    this._makeApiCall = _apicallREF;
   }


  ngOnInit(): void {
  }

}
