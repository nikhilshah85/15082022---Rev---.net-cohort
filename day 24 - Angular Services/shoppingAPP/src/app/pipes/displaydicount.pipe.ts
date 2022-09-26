import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'displaydicount'
})
export class DisplaydicountPipe implements PipeTransform {

 
  transform(value:number, category:string)
  {
    if(category == 'Cold-Drink')
    {
      return value * 10 / 100;
    }
    else if(category == 'Electronics')
    {
      return value * 20 / 100;
    }
    else if(category == 'Accessories')
    {
      return value * 7.5 / 100;
    }
    return value; //this means no discount
  }
}
