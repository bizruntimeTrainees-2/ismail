

const source = rxjs.interval(1000);
const example = source.pipe(
  rxjs.operators.take(10),
  rxjs.operators.toArray()
);
 
const subscribe = example.subscribe(val => console.log(val));
 