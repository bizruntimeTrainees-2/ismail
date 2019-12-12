
const clicks3 = rxjs.fromEvent(document, 'click');
const result3 = clicks3.pipe(rxjs.operators.debounceTime(5000));
result3.subscribe(x => console.log('debounceTime: ', x));//emits only after 5secs


const clicks4 = rxjs.fromEvent(document, 'click');
const result4 = clicks4.pipe(rxjs.operators.debounce( () => rxjs.interval(1000)));
result4.subscribe(x => console.log('debounce: ', x));//emits only after 1secs

//diff is  'the time span of emission silence is determined by a second Observable.'

