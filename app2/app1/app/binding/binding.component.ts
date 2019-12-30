import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-binding',
  template:`<h2 class="text-success">
     Welcome {{name}}
  </h2>
  <h2>{{greatUser()}}</h2>

  <h2 [class]="sucessClass">{{siteUrl}}</h2>

  <input [id]="myId" type="text" value="Ismail"/>
  <input bind-disabled="isDisabled" id="{{myId}}" type="text" value="Ismail"/>

  <h2 [class.text-danger]="hasError">calss binding Text Error</h2>
  <h2 [ngClass]="messageClasses">ngClass</h2>
  
  <h2 [style.color]="hasError ?'orange' : 'lightblue'">Style binding1 </h2>
  <h2 [style.color]="highlightColor">Style binding2 </h2>
  <h2 [ngStyle]="titleStyles">ngStyle binding3 </h2>

   <button (click)="onClick($event)">Greet1</button>&nbsp;
   <button (click)="greeting='welcome User'">Greet2</button>
   {{greeting}}
   <br/>
   <br/>
   <input #myInput type="text" placeholder="result display in console">
   <button (click)="LogMessage(myInput.value)" >Log</button>&nbsp;
   <br/>
   <br/>
    <h2>two way binding</h2>
   <input [(ngModel)]="name1"  type="text" placeholder="two-way-binding">
   {{name1}}
   
  `,
  styles:[`
  .text-success{
    color: green;
  }
  .text-danger{
    color: red;
  }
  .text-special{
    font-style: italic;
  }
  `]
 // templateUrl: './binding.component.html',
 // styleUrls: ['./binding.component.css']
})
export class BindingComponent implements OnInit {
public name = "Ismail";
public siteUrl = window.location.href;
public myId = "bindingId";
public isDisabled = true;
public sucessClass = "text-danger";
public hasError = false;
public isSpecial = true;
public messageClasses ={
  "text-sucess":!this.hasError,
  "text-danger":this.hasError,
  "text-special":this.isSpecial

}
public highlightColor = "darkblue";
public titleStyles = {
  color: "blue",
  fontStyle: "italic"
}
public greeting="";
  constructor() { }
  ngOnInit() { 
  }

  greatUser(){
    return "Hello "+ this.name;
  }
  onClick(event){
    console.log(event);
    this.greeting = event.type;
  }
  LogMessage(value){
    console.log(value);
  }
}
