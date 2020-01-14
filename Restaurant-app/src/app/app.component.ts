import { Component } from '@angular/core';
import { CustomerService } from 'base';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  sda: any;
  /**
   *
   */
  constructor(apiGen: CustomerService) {
    const fun = async () => {
      const result = await apiGen.getCustomer(2);
      console.log(result);

    }

    fun();
  }
}
