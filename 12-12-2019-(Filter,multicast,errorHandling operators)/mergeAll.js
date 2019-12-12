

const clicks3 = rxjs.fromEvent(document, 'click');
const higherOrder2 = clicks3.pipe(
 rxjs.operators.map((ev) => rxjs.interval(1000).pipe(rxjs.operators.take(5))),
);
const firstOrder1 = higherOrder2.pipe(rxjs.operators.mergeAll(2));
firstOrder1.subscribe(x => console.log('mergeAll: ',x));