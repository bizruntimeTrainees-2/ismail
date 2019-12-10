const firstTimer = rxjs.timer(0, 1000)
const secondTimer = rxjs.timer(500, 1000)

const combinedTimers = rxjs.combineLatest(firstTimer, secondTimer);
var combine$ = combinedTimers.subscribe(val => console.log(val));

setTimeout(() => {
    combine$.unsubscribe();
}, 5000);

const observables = [1,5,10].map(
    n => rxjs.of(n).pipe(
        rxjs.operators.delay(n * 1000),
        rxjs.operators.startWith(0)
    )
);
const combine1 = rxjs.combineLatest(observables);
var combine1$ = combine1.subscribe(val => console.log("observables:" +val));

setTimeout(() => {
    combine1$.unsubscribe();
}, 5000);
