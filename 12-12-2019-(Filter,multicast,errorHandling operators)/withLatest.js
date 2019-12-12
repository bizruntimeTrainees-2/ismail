
//withLatestFrom
//On every click event, emit an array with the latest timer event plus the click event
const clicks4 = rxjs.fromEvent(document, 'click');
const timer4 = rxjs.interval(1000);
const result4 = clicks4.pipe(rxjs.operators.withLatestFrom(timer4));
result4.subscribe(x => console.log('withLatest: ',x));

