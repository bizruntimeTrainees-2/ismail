const switched = rxjs.of(1,2,3).pipe(
                               rxjs.operators.switchMap((x) => rxjs.of(x, x ** 2, x ** 3)));
switched.subscribe(x => console.log('switched: ',x));