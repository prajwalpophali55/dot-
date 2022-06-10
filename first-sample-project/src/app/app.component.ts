import { Component } from '@angular/core';
import { Customer } from './app.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'first-sample-project';
  myname='prajwal pophali'
  CustomerModel:Customer=new Customer();
  CustmerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() {
    this.CustmerModels.push(this.CustomerModel);
    this.CustomerModel = new Customer();
  }
  EditCustomer(input: Customer) {
    //console.log(input);
    this.CustmerModels.shift();
   this.CustomerModel=new Customer();

  }
  DeleteCustomer(input: Customer) {
   // console.log(input);
   this.CustmerModels.shift();
   this.CustomerModel=new Customer();

  }
}

