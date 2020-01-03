import {FlatTreeControl}  from '@angular/material';
import {Component} from '@angular/core';
import {MatTreeFlatDataSource, MatTreeFlattener} from '@angular/material';

interface FoodNode {
 name: string;
 children? : FoodNode[];  
}

const Tree_Data : FoodNode[] = [
 { 
     name: 'Fruit',
     children: [
      {name:'Apple'},
      {name:'Banana'},
      {name:'Fruit loops'}
     ]
 },   {
  name: 'Vegetables',
  children:[
    {
      name: 'Green',
      children: [{name:'pumpkin'},{name:'Carrots'}]
    }
  ]
 }
];

interface ExampleFlatNode {
  expandable: boolean;
  name: string;
  level: number;
}

@Component ({
  selector: 'tree-flat-overview-example',
  templateUrl: 'tree-flat-overview-example.html',
  styleUrls: ['tree-flat-overview-example.css']
})

export class TreeFlatOverviewExample{
    private  _transformer = (node: FoodNode, level: number) => {
                 return {
		    expandable: ! !node.children && node.children.length > 0,
		    name: node.name,
		    level: level
		 };
    }
    
    treeControl = new FlatTreeControl<ExampleFlatNode> (
     node => node.level, node => node.expandable );

     treeFlattener = new MatTreeFlattener (
       this._tranformer,  node => node.level, node => node.expandable,
                         node.children);
		
	dataSource = new  MatTreeFlatDataSource(this.treeControl, this.treeFlattener);
	constructor() {
	  this.dataSource.data = Tree_Data ;
	}

	hasChild = ( _: number, node: ExampleFlatNode) => node.expandable;     
}