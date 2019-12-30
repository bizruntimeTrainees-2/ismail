import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes',
  template:`
  <h2>{{name}} </h2>
  <h2> {{name | lowercase}} </h2>
  <h2> {{name | uppercase}} </h2>
  <h2> {{message | titlecase}} </h2>
  <h2> {{name | slice:2:5}} </h2>
  <h2> {{person | json}} </h2>
  
   <h2> {{12.225 | number:'2.2-3'}}</h2>
   <h2> {{12.225 | number:'2.4-4'}}</h2>
   <h2> {{12.225 | number:'3.2-2'}}</h2>

   <h2> {{0.25 |percent}}</h2>
   <h2> {{0.25 |currency : 'EUR' :'code'}}</h2>

   <h2> {{date}} </h2>
   <h2> {{date | date:'shortDate'}} </h2>
   <h2> {{date |date:'shortTime'}} </h2>
   <h2> {{date |date:'longDate'}} </h2>
   <h2> {{date |date:'longTime'}} </h2>

  `,
  styles:[]
  //templateUrl: './pipes.component.html',
  //styleUrls: ['./pipes.component.css']
})
export class PipesComponent implements OnInit {

  public name = "Ismail Pathan";
  public message = "Welcome to angular";
  public person ={
    "FirstName" :"Ismail",
    "LastName" : "Pathan"
  }
  public date = new Date();
  constructor() { }

  ngOnInit() {
  }

}
