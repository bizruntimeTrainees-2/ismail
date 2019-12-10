

const clicks = rxjs.fromEvent(document, 'click');
const intervalEvents = rxjs.interval(1000);
const buffered = intervalEvents.pipe(rxjs.operators.buffer(clicks));
var buffered$ = buffered.subscribe( x => console.log('buffer: '+x));  

const buffered1 = intervalEvents.pipe(rxjs.operators.bufferCount(4));
var buffered1$ =buffered1.subscribe( x => console.log("bufferCount: "+x));  

const buffered2 = intervalEvents.pipe(rxjs.operators.bufferTime(1000));
var buffered2$ =buffered2.subscribe( x => console.log("bufferTimer: "+x));


const buffered3 = clicks.pipe(rxjs.operators.bufferToggle(intervalEvents, i =>
  i % 2 ? rxjs.interval(500) : rxjs.operators.EMPTY
));
var buffered3$ = buffered3.subscribe(x => console.log("buffered toggle: "+x));

const buffered4 = intervalEvents.pipe(rxjs.operators.bufferWhen(() =>
rxjs.interval(1000 + Math.random() * 400) 
));
var buffered4$ =buffered4.subscribe( x => console.log("bufferWhen: "+x));


setTimeout(() => {
    buffered$.unsubscribe(),
    buffered1$.unsubscribe(),
    buffered2$.unsubscribe(),
    buffered3$.unsubscribe(),
    buffered4$.unsubscribe()
}, 10000);