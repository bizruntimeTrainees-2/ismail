import { Component, OnInit } from '@angular/core';
import { Content } from '@angular/compiler/src/render3/r3_ast';

@Component({
  selector: 'app-services',
  template:`
  <h2> Employee List</h2>
  <ul *ngFor = "let employee of Emp_details">
    <li>{{employee.name}} </li>
  </ul>
  `,
  styles:[]
 // templateUrl: './services.component.html',
  //styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  public Emp_details=[
    {"id":1,"name":"Ismail","age":21},
    {"id":2,"name":"Hussain","age":22},
    {"id":3,"name":"Isreal","age":21},
    {"id":4,"name":"Tiru","age":20}
  ];
  constructor() { }

  ngOnInit() {
  }

}
