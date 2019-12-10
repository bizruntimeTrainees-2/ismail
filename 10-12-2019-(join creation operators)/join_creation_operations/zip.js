const age$ = rxjs.of(20,21,18,25);
const name$ = rxjs.of('foo', 'bar','beer');
const isDev$ = rxjs.of(true, true, false);

rxjs.zip(age$,name$,isDev$).pipe(
    rxjs.operators.map(([age,name, isDev]) => ({age, name, isDev})),
)
.subscribe(x => console.log(x));


