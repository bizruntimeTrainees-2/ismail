
const clicks7 = rxjs.fromEvent(document, 'click');
 const sec = rxjs.interval(1000);
 const result7 = clicks7.pipe(
     rxjs.operators.window(sec),
     rxjs.operators.map(win => win.pipe(rxjs.operators.take(2))), // each window has at most 2 emissions
     rxjs.operators.mergeAll(),              // flatten the Observable-of-Observables
 );
 result7.subscribe(x => console.log('window: ',x));

 const clicks8 = rxjs.fromEvent(document, 'click');
const result8 = clicks8.pipe(
  rxjs.operators.windowWhen(() => rxjs.interval(1000 + Math.random() * 4000)),
 rxjs.operators.map(win => win.pipe(rxjs.operators.take(2))),     // each window has at most 2 emissions
  rxjs.operators.mergeAll()                         // flatten the Observable-of-Observables
);
result8.subscribe(x => console.log('windowWhen: ',x));


const clicks9 = rxjs.fromEvent(document, 'click');
const result9 = clicks9.pipe(
    rxjs.operators.windowCount(3),
    rxjs.operators.map(win => win.pipe(  rxjs.operators.skip(1))), // skip first of every 3 clicks
    rxjs.operators.mergeAll()                     // flatten the Observable-of-Observables
);
result9.subscribe(x => console.log('windowCount:',x));