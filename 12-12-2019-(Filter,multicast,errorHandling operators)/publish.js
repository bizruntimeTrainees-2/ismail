
//Makes a cold Observable hot

const source$ = rxjs.zip(rxjs.interval(2000), rxjs.of(1, 2, 3, 4, 5, 6, 7, 8, 9)).pipe(
  rxjs.operators.map(values => values[1])
);
 
source$
  .pipe(
      rxjs.operators.publish(multicasted$ =>
        rxjs.merge(
        multicasted$.pipe(  rxjs.operators.tap(x => console.log('Stream 1:', x))),
          multicasted$.pipe(  rxjs.operators.tap(x => console.log('Stream 2:', x))),
      )
    )
  )
  .subscribe();
