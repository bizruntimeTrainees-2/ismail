
// synchronously
const a1 = rxjs.of(1, 2, 3, 4);
const b1 = rxjs.of(5, 6, 7, 8, 9);
rxjs.merge(a1, b1).subscribe(console.log);



//async
const a = rxjs.of(1, 2, 3, 4).pipe(rxjs.operators.subscribeOn(rxjs.asyncScheduler));
const b = rxjs.of(5, 6, 7, 8, 9);
rxjs.merge(a, b).subscribe(console.log);