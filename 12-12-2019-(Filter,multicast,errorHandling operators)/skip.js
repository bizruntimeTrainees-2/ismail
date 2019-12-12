
//skips last two 
const many = rxjs.range(1, 5);
const skipLastTwo = many.pipe(rxjs.operators.skipLast(2));
skipLastTwo.subscribe(x => console.log("skip: ",x));


//skip untill
const intervalObservable = rxjs.interval(1000);
const click12 = rxjs.fromEvent(document, 'click');
 
const emitAfterClick = intervalObservable.pipe(
  rxjs.operators.skipUntil(click12)
);

const subscribe = emitAfterClick.subscribe(value => console.log('skipUntill',value));