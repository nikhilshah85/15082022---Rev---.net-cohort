import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'discount'
})
export class DiscountPipe implements PipeTransform {

  transform(value: any, category:string) {
    if(category == 'Drink')
    {
      return value * 5 /100;
    }
    else if(category == 'Electronics')
    {
      return value  * 12 / 100;
    }
    else if(category == 'Fast-Food')
    {
      return value * 20 / 100;
    }
    return value * 10 / 100;
  }

}
