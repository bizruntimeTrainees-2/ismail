//take

const intervalCount = rxjs.interval(1000);
const takeFive = intervalCount.pipe(rxjs.operators.take(4));
takeFive.subscribe(x => console.log('take: ',x));

//takeLast three
const many1 = rxjs.range(1, 10);
const lastThree = many1.pipe(rxjs.operators.takeLast(3));
lastThree.subscribe(x => console.log('takelast: ',x));

//take until
const source1 = rxjs.interval(1000);
const clicks13 = rxjs.fromEvent(document, 'click');
const result13 = source1.pipe(rxjs.operators.takeUntil(clicks13));
//stops taking when dom is clicked
result13.subscribe(x => console.log('takeUntill: ',x));

//takewhile

const clicks14 = rxjs.fromEvent(document, 'click');
const result14 = clicks14.pipe(rxjs.operators.takeWhile(ev => {ev.screenY>100; console.log(ev)} ));
result14.subscribe(x => console.log('takewhile:',x));