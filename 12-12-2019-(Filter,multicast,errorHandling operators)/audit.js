

const clicks1 = rxjs.fromEvent(document,'click');
const result1 = clicks1.pipe(rxjs.operators.audit( val => rxjs.interval(5000)));
//emits after 5secs
result1.subscribe( x => console.log(x));//output :MouseEvent {isTrusted: true, screenX: 34, screenY: 285, clientX: 33, clientY: 205, …}

const clicks2 = rxjs.fromEvent(document,'click');
const result2 = clicks2.pipe(rxjs.operators.auditTime(10000));
//emits only after 10sec 
result2.subscribe( x => console.log('auditTime'+x));//output: auditTime[object MouseEvent]

