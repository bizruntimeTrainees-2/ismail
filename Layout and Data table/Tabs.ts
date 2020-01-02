import {Component} from '@angular/core';
import {FormControl} from '@angular/forms';

@Component({
     selector: 'tab-group-dynamic-example',
     templateUrl: 'tab-group-dynamic-example.html',
     styleUrls: ['tab-group-dynamic-example.css']
     })
     export class TabGroupDynamicExample{
        tabs = ['First','Second','Third'];
	selected= new FormControl(0);

	addTab(selectedAfterAdding: boolean){
	  this.tabs.push('New');
	  if(selectAfterAdding) {
	   this.selected.setValue(this.tabs.length-1);
	  }
    }

	  removeTab(index:number) {
	    this.tabs.splice(index, 1);
	    }
}