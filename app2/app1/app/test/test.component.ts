import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-test',
  template:  `<div> Inline tmplate</div>`,
  styles:[`
  div{
    color:red;
  }`]
  //templateUrl : './test.component.html',
 // styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    title:'test-work!'
  }
}

