

rxjs.of(1, 2, 3, 4, 5).pipe(
    rxjs.operators.map(n => {
  	   if (n === 4) {
	       throw 'function not defined!';
      }
     return n;
    }),
    rxjs.operators.catchError(err => rxjs.of('error is : '+ err)),
  )
  .subscribe(x => console.log('errors: ',x));