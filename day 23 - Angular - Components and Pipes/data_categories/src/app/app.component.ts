import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
 

//Primitive data typess
appName:string="Angular Dta Categories";
appDeveloper:string = "Nikhil";
appTeamSize:number = 20;
appIsLive:boolean = false;
appProjectCost:number = 2500000

//Primitive data array
techList:string[] =['Angular','Google Material','WEBAPI', 'Bootstrap','Node']


//JSON object
clientDetails:any = 
                   {clietnId:101,
                    clientName:'ABCZ Corp', 
                    clientLocation:'Vancover',
                     clientProject:'Insurance'}


//JSON Object Array 
clientList:any[] = [
  {clietnId:101, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:102, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:103, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:104, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:105, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:106, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:107, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:108, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},
  {clietnId:109, clientName:'ABCZ Corp',  clientLocation:'Vancover', clientProject:'Insurance'},

] 


}
