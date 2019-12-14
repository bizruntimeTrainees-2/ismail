
//Counts how many seconds have passed before the first click happened
const seconds = rxjs.interval(1000);
const clicks = rxjs.fromEvent(document, 'click');
const secondsBeforeClick = seconds.pipe(rxjs.operators.takeUntil(clicks));
const result1 = secondsBeforeClick.pipe(rxjs.operators.count());
result1.subscribe(x => console.log('no of seconds before click: ',x));

//Counts how many odd numbers are there between 0 and 100
const numbers = rxjs.range(0, 100);
const result2 = numbers.pipe(rxjs.operators.count(i => i % 2 === 0));
result2.subscribe(x => console.log("no of Even no:",x));


//max number
const numbers1 = rxjs.range(0, 10);
const result3 = numbers1.pipe(rxjs.operators.max());
result3.subscribe(x => console.log("max no:",x));

//min  number
const numbers2 = rxjs.range(0, 10);
const result4 = numbers2.pipe(rxjs.operators.min());
result4.subscribe(x => console.log("min no:",x));

//reduce  number
const numbers3 = rxjs.range(0, 5);
const seed = 0;
const result5 = numbers3.pipe(rxjs.operators.reduce((total, one) => total + one, seed));
result5.subscribe(x => console.log("total sum of values:",x));

