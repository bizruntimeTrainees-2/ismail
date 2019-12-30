import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router, ParamMap} from '@angular/router';

@Component({
  selector: 'app-department-detail',
  template: `
    <h3>
      You selected department with id = {{departmentId}}
    </h3>
    <p>
    <button><a (click)="showOverview()">showOverview</a></button>&nbsp;
    <button><a (click)="showContact()">showContact</a></button><br/>
    </p>
    <router-outlet></router-outlet>
    <button><a (click)="goPrevious()">Previous</a></button>&nbsp;
    <button><a (click)="goNext()">Next</a></button><br/>
    <div>
    <button (click)="goBack()">Back</button>
    </div>
  `,
  styles: []
})
export class DepartmentDetailComponent implements OnInit {

public departmentId;
  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
   // let id = parseInt(this.route.snapshot.paramMap.get('id'));
    //this.departmentId= id;
    this.route.paramMap.subscribe((params: ParamMap) => {
      let id = parseInt(params.get('id'));
      this.departmentId=id;
    })
  }
goPrevious(){
  let prevId = this.departmentId-1;
  this.router.navigate(["/departments", prevId])
}
goNext(){
  let nextId = this.departmentId+1;
  this.router.navigate(["/departments", nextId])
}
goBack(){
  let selectedId = this.departmentId ? this.departmentId: null;
  this.router.navigate(['/departments', {id: selectedId}]);
 //  this.router.navigate(["../", {id: selectedId} ], { relativeTo:this.route});
}
showOverview(){
  this.router.navigate(['overview'], {relativeTo: this.route});
}
showContact(){
  this.router.navigate(['contact'], {relativeTo: this.route})
}
}
