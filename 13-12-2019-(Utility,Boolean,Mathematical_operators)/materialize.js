
//materialize 
//it wraps next, error, or complete  and emit for each emit value
const letters = rxjs.of('a','b',13,'d');
const upperCase = letters.pipe(rxjs.operators.map(x => x.toUpperCase()));
const materialized1 = upperCase.pipe(rxjs.operators.materialize());
materialized1.subscribe(x => console.log(x));


//dematerialize
//unwraps 

const notifA = new rxjs.Notification('N', 'A');
const notifB = new rxjs.Notification('N', 'B');
const notifE = new rxjs.Notification('E', undefined,
  new TypeError('x.toUpperCase is not a function')
);
const materialized2 = rxjs.of(notifA, notifB, notifE);
const lowerCase = materialized2.pipe(rxjs.operators.dematerialize());
lowerCase.subscribe(
                        x => console.log(x),
                        err => console.log(err));
