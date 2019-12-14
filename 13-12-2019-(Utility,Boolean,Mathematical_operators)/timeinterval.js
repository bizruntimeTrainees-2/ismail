

const seconds = rxjs.interval(1000);
 
 seconds.pipe(rxjs.operators.timeInterval())
.subscribe(
    value => console.log(value),
    err => console.log(err),
);
 
seconds.pipe(rxjs.operators.timeout(999))
.subscribe(
    value => console.log('timeout lessthan time interval: ',value),
    err => console.log(err),
);
seconds.pipe(rxjs.operators.timeout(1000))
.subscribe(
    value => console.log('timeout equals to timeinterval: ',value),
    err => console.log(err),
);

seconds.pipe(rxjs.operators.timeout(1001))
.subscribe(
    value => console.log('timeout greaterthan time interval: ',value),
    err => console.log(err),
);
