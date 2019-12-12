
rxjs.of(1,1,1,2,2,3,3,4,4,4,4).pipe(
rxjs.operators.distinct(name)
).subscribe( x => console.log('distinct: ',x))//1,2,3,4


rxjs.of(1, 1, 2, 2, 2, 1, 1, 2, 3, 3, 4).pipe(
    rxjs.operators.distinctUntilChanged(),
  )
  .subscribe(x => console.log('distinctUntilChanged: ',x));//1,2,1,2,3,4