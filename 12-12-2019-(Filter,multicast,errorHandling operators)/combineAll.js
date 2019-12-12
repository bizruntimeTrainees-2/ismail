
//Map two click events to a finite interval Observable, then apply combineAll

const clicks1 = rxjs.fromEvent(document, 'click');
const higherOrder = clicks1.pipe(
  rxjs.operators.map(ev =>
     rxjs.interval(Math.random() * 2000).pipe( rxjs.operators.take(3))
  ),
  rxjs.operators.take(4)
);
const result1 = higherOrder.pipe(
  rxjs.operators.combineAll()
);
 
result1.subscribe(x => console.log('combineAll: ',x));