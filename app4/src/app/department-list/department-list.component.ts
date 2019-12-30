import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap} from '@angular/router';

@Component({
  selector: 'app-department-list',
  template: `
    <h3>
      Department List 
    </h3>
    <ul class="items">
       <li (click)="onSelect(dprt)" [class.selected]="isSelected(dprt)"  *ngFor="let dprt of departments">
          <span class="badge">{{dprt.id}}.</span><button> {{dprt.name}}</button>
       </li>
    </ul>
  `,
  styles: []
})
export class DepartmentListComponent implements OnInit {

  public selectedId;
   departments = [
   {"id":1, "name": "Angular"},
   {"id":2, "name": "Node"},
   {"id":3, "name": "MongoDB"},
   {"id":4, "name": "Ruby"},
   {"id":5, "name": "bootstrap"}
 ]
  constructor( private router: Router, private route:ActivatedRoute) { }

  ngOnInit() {
    this.route.paramMap.subscribe((params: ParamMap) => {
      let id = parseInt(params.get('id'));
      this.selectedId=id;
    })
  }
 isSelected(department){
  return department.id === this.selectedId;
 }
  onSelect(department){
    this.router.navigate(['/departments', department.id]);    
  //this.router.navigate([department.id], { relativeTo: this.route});
  }
  
}
