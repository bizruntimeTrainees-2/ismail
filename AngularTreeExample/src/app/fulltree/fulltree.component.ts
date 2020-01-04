import { Component, OnInit } from '@angular/core';
import { TreeNode, TreeModel, TREE_ACTIONS, KEYS, IActionMapping, ITreeOptions } from 'angular-tree-component';

@Component({
  selector: 'app-fulltree',
templateUrl: './fulltree.component.html',
// template: '<tree-root [nodes]="nodes" [focused]="true" [options]="options"></tree-root>';
  styleUrls: ['./fulltree.component.css']
})
export class FulltreeComponent implements OnInit {

  nodes = [
    {
      name: 'root1',
      children: [
        { name: 'child1' },
        { name: 'child2' }
      ]
    },
    {
      name: 'root2',
      children: [
        { name: 'child2.1', children: [] },
        { name: 'child2.2', children: [
          {name: 'grandchild2.2.1'}
        ] }
      ]
    },
    { name: 'root3' },
    { name: 'root4', children: [] },
    { name: 'root5', children: null }
  ];
  constructor() { }

  ngOnInit() {
  }
onEvent($event)
{
  console.log($event);
}
}
