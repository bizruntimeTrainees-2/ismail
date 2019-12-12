//concat all 
//  with no concurrency
const clicks2 = rxjs.fromEvent(document, 'click');
const higherOrder = clicks2.pipe(
  rxjs.operators.map(ev => rxjs.interval(1000).pipe( rxjs.operators.take(4))),
);
const firstOrder = higherOrder.pipe(rxjs.operators.concatAll());
firstOrder.subscribe(x => console.log('concatAll: ',x));