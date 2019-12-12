
const source = rxjs.interval(1000);
const example = source.pipe(
  rxjs.operators.mergeMap(val => {
    if(val > 3){
       throw 'Error occured!';
    }
    return  rxjs.of(val);
  }),
  //retry 1 times on error
   rxjs.operators.retry(1)
);
 
const subscribe = example.subscribe({
  next: val => console.log(val),
  error: val => console.log(`${val}: Retried 1 time!`)
});
 