import { Component } from '@angular/core';
import {User } from './user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Ticket Booking';
  buses = ['APSRTC','TSRTC','Travells'];
  userModel = new User('Roy','roy@t.com',55555444,'', 'morning', true);
}
