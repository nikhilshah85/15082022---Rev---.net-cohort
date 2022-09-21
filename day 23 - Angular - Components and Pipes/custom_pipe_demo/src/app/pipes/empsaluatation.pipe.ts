import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'empsaluatation'
})
export class EmpsaluatationPipe implements PipeTransform {


  transform(value: any, gender:string) {
    if(gender == 'Male')
    {
      return 'Mr.' +value;
    }
    else
    {
      return 'Mrs.' + value;
    }
  }

}
