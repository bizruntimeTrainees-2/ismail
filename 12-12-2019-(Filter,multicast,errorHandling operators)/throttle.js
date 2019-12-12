
const clicks5 = rxjs.fromEvent(document,'click');
const result5 =  clicks5.pipe(rxjs.operators.throttle ((ev) => {rxjs.interval(1000);}));
// As soon as the first source value arrives, it is forwarded to the output
result5.subscribe(x => console.log('throttle: ',x));

const clicks6 = rxjs.fromEvent(document,'click');
const result6 =  clicks6.pipe(rxjs.operators.throttleTime(5000));
// As soon as the first source value arrives, it is forwarded to the output
//for more than two clicks at a time throttle time won't display o/p immediately
result6.subscribe(x => console.log('throttleTime: ',x));