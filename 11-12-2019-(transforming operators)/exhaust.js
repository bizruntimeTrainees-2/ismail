/*
const clicks = rxjs.fromEvent(document, 'click');
const  higherOrder = clicks.pipe(
                                     rxjs.operators.map( (ev) => rxjs.interval(1000).pipe( rxjs.operators.take(5) )));

const results = higherOrder.pipe(rxjs.operators.exhaust());
results.subscribe(x => console.log(x));
*/

/*
const clicks = rxjs.fromEvent(document, 'click');
const  higherOrder = clicks.pipe(
                                     rxjs.operators.exhaustMap( (ev) => rxjs.interval(1000).pipe( rxjs.operators.take(5) )));

higherOrder.subscribe(x => console.log(x));
*/
const clicks = rxjs.fromEvent(document, 'click');
const powersOfTwo = clicks.pipe(
    rxjs.operators.mapTo(1),
     rxjs.operators.expand(x =>  rxjs.of(2 * x).pipe( rxjs.operators.delay(1000))),
     rxjs.operators.take(5),
);
powersOfTwo.subscribe(x => console.log(x));