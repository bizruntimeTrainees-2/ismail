import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Material';
  opened= false;

log(state){
  console.log(state)
}
  loadData()
  {
  this.spinner = true;
  setTimeout( () =>{
    this.spinner = false;
  },5000)
}
}
