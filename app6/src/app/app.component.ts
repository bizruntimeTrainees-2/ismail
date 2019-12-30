import { Component } from '@angular/core';
import {User } from './user';
import { EnrollmentService} from './enrollment.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Ticket Booking';
  buses = ['APSRTC','TSRTC','Travells'];
  topicHasError=true;
  submitted = false;
  errorMsg ='';
  userModel = new User('','roy@t.com',5555544441,'default', 'morning', true);
  constructor(private _enrollmentService: EnrollmentService){}
  validateTopic(value)
  {
    if(value === "default")
    {
    this.topicHasError=true;
    }
    else{
      this.topicHasError=false;
    }
  }
  onSubmit()
  {
   this.submitted = true;
    this._enrollmentService.enroll(this.userModel)
     .subscribe(
      data => console.log('success!', data),
      error => this.errorMsg = error.statusText
    )
  }
}
