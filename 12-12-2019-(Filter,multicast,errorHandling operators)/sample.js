
const seconds = rxjs.interval(1000);
const clicks7 = rxjs.fromEvent(document, 'click');
const result7 = seconds.pipe(rxjs.operators.sample(clicks7));
// The sampling starts as soon as the output Observable is subscribed.
result7.subscribe(x => console.log('sampling: ',x));


const clicks8 = rxjs.fromEvent(document, 'click');
const result8 = clicks8.pipe(rxjs.operators.sampleTime(1000));
//Every second, emit the most recent click at most once
result8.subscribe(x => console.log('sampleTime: ',x));