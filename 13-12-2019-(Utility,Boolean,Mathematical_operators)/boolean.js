

const clicks1 = rxjs.fromEvent(document, 'click');
const clicksBeforeFive = clicks1.pipe(rxjs.operators.takeUntil(rxjs.interval(5000)));
const result1 = clicksBeforeFive.pipe(rxjs.operators.defaultIfEmpty('no clicks')
                         );
result1.subscribe(x => console.log(x));


//Returns an Observable that emits 
//whether or not every item of the source satisfies the condition specified.
 rxjs.of(1, 2, 3, 4, 5).pipe(
    rxjs.operators.every(x => x < 5),
)
.subscribe(x => console.log(x)); // -> false


//emits the first value that satisfies condition
const clicks2 = rxjs.fromEvent(document, 'click');
const result2 = clicks2.pipe(rxjs.operators.find(ev => ev.target.tagName === 'BODY'));
result2.subscribe(x => console.log("clicked on:",x.target.tagName));


//emits the first value  index only that satisfies condition
const clicks3 = rxjs.fromEvent(document, 'click');
const result3 = clicks3.pipe(rxjs.operators.findIndex(ev => ev.target.tagName === 'P'));
result3.subscribe(x => console.log("clicked at index:",x));


//Tells whether any values are emitted by an observable
const result4 = rxjs.EMPTY.pipe(rxjs.operators.isEmpty());
result4.subscribe(x => console.log("isEmpty: ",x));
