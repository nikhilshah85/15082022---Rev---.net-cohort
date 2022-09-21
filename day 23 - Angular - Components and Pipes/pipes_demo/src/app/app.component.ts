import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  
  // firstName  = "nikHil";
  // lastName = "Shah";
  // designation = "Consultant";
  // salary = 140000;
  // doj = new Date();

  // orderDetails = {
  //   oId:101, oValue:200, oDate:'10-Jan-2022',oLocation:'NYK',oProduct:'T-shirt'
  //   }


  empList = [
    {empNo:101, empName:'Ricki', empDesignation:'HR', empSalary:3000, empDOJ : '10/10/2014',empGender:'Female'},
    {empNo:102, empName:'Marriah', empDesignation:'Accounts', empSalary:3000, empDOJ : '08/18/2016',empGender:'Female'},
    {empNo:103, empName:'Mary', empDesignation:'HR', empSalary:3000, empDOJ : '06/30/2008',empGender:'Female'},
    {empNo:104, empName:'Jordan', empDesignation:'Accounts', empSalary:3000, empDOJ : '11/20/2021',empGender:'Male'},
    {empNo:105, empName:'Boleski', empDesignation:'HR', empSalary:3000, empDOJ : '10/12/2016',empGender:'Female'},
    {empNo:106, empName:'Mauris', empDesignation:'HR', empSalary:3000, empDOJ : '09/10/2018',empGender:'Male'},
    {empNo:107, empName:'Hayden', empDesignation:'Accounts', empSalary:3000, empDOJ : '01/10/2020',empGender:'Male'},
    {empNo:108, empName:'Mark', empDesignation:'Sales', empSalary:3000, empDOJ : '05/14/2010',empGender:'Male'},
    {empNo:109, empName:'Spencer', empDesignation:'HR', empSalary:3000, empDOJ : '03/23/2009',empGender:'Male'},
    {empNo:110, empName:'Ronaldo', empDesignation:'Sales', empSalary:3000, empDOJ : '10/28/1990',empGender:'Male'},
    {empNo:111, empName:'Messieee', empDesignation:'Sales', empSalary:3000, empDOJ : '02/10/2002',empGender:'Male'},

  ]



}
