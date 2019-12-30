import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ngif-for-switch',
  template:`
  <div *ngIf = "display; then thenBlock; else elseBlock"></div>  
<ng-template #thenBlock>
<h2>
  ngIf if directive1
</h2>
</ng-template>

<ng-template #elseBlock>
  <h2>
    ngIf else directive2
  </h2>
</ng-template>

<div [ngSwitch]="color">
  <div *ngSwitchCase="'red'"> ngswitch: caseyou picked red</div>
  <div *ngSwitchCase="'blue'">ngswitch: you picked blue</div>
  <div *ngSwitchCase="'green'">ngswitch: you picked green</div>
  <div *ngSwitchDefault>picked again</div>
</div>

<div *ngFor="let brand of brands ; even as e">
<h2> {{e}}:{{brand}} </h2>
</div>

  `,
  styles:[]
  //templateUrl: './ngif-for-switch.component.html',
  //styleUrls: ['./ngif-for-switch.component.css']
})
export class NgifForSwitchComponent implements OnInit {

  public display= true;
  public color = "blue";
  public brands = ["puma","Nike","Adidas","sparx"];
  constructor() { }

  ngOnInit() {
  }

}
