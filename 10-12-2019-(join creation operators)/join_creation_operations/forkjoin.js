const observable = rxjs.forkJoin([
    rxjs.of(1, 2, 3,4,5),
     Promise.resolve(8),
    rxjs.timer(2000)
]);
observable.subscribe({
   next: value => console.log(value),
   complete:() => console.log('this is how  ending!')
});
