import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {



  customers  = ['Customer A ', 'Customer B', 'Customer C', 'Customer D', 'Customer E', 'Customer F' ]
  constructor() { }

  ngOnInit(): void {
  }

}
