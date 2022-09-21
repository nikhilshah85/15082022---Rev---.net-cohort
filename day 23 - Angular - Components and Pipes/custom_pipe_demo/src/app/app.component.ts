import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  empList = [
    {empNo:101, empName:'Katty',empDesignation:'Sales', empSalary:3000,empGender:'Famale'},
    {empNo:102, empName:'Mark',empDesignation:'HR', empSalary:3000,empGender:'Male'},
    {empNo:103, empName:'Micheal',empDesignation:'Sales', empSalary:3000,empGender:'Male'},
    {empNo:104, empName:'Sandra',empDesignation:'Sales', empSalary:3000,empGender:'Famale'},
    {empNo:105, empName:'Louis',empDesignation:'Sales', empSalary:3000,empGender:'Male'},
    {empNo:106, empName:'Peter',empDesignation:'HR', empSalary:3000,empGender:'Male'},
    {empNo:107, empName:'Marryjane',empDesignation:'Sales', empSalary:3000,empGender:'Famale'},
    {empNo:108, empName:'Osborn',empDesignation:'Sales', empSalary:3000,empGender:'Male'},
    {empNo:109, empName:'Black Panther',empDesignation:'Sales', empSalary:3000,empGender:'Male'},
    {empNo:110, empName:'Hit-Man',empDesignation:'Accounts', empSalary:3000,empGender:'Male'},
    {empNo:111, empName:'John',empDesignation:'Sales', empSalary:3000,empGender:'Male'},
    {empNo:112, empName:'Sieana',empDesignation:'Accounts', empSalary:3000,empGender:'Famale'},
  ]


}
