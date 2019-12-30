import { Component, OnInit,Input, Output,EventEmitter } from '@angular/core';


@Component({
  selector: 'app-component-interaction',
  template:`
  <h2> {{"Hello "+name}} </h2><br/>
  <button (click) = "fireEvent()">send event</button>
  `,
  styles:[]
  //templateUrl: './component-interaction.component.html',
  //styleUrls: ['./component-interaction.component.css']
})
export class ComponentInteractionComponent implements OnInit {

 @Input('parentData') public name;
 @Output() public childEvent = new EventEmitter();


  constructor() { }

  ngOnInit() {
  }
  fireEvent(){
    this.childEvent.emit('hey Ismail')
  }
}
