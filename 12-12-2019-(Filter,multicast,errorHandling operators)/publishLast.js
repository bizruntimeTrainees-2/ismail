//publish last 
//it waits untill the source obser completes and stores the last emitted value

const connectable =
  rxjs.interval(1000)
    .pipe(
      rxjs.operators.tap(x => console.log("side effect", x)),
       rxjs.operators.take(3),
       rxjs.operators.publishLast());
 
connectable.subscribe(
  x => console.log(  "Sub. A", x),
  err => console.log("Sub. A Error", err),
  () => console.log( "Sub. A Complete"));
 
connectable.subscribe(
  x => console.log(  "Sub. B", x),
  err => console.log("Sub. B Error", err),
  () => console.log( "Sub. B Complete"));
 
connectable.connect();
 