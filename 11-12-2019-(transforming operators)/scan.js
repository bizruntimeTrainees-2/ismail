
const click$ = rxjs.fromEvent(document, 'click');
const one$ = click$.pipe(rxjs.operators.mapTo(1));
const seed = 0;
const count$ = one$.pipe(
  rxjs.operators.mergeScan((acc, one) => rxjs.of(acc + one), seed),
);
count$.subscribe(x => console.log('mergescan: '+x));

const click$1 = rxjs.fromEvent(document, 'click');
const one$1 = click$1.pipe(rxjs.operators.mapTo(1));
const seed1 = 0;
const count$1 = one$1.pipe(
  rxjs.operators.mergeScan((acc, one) => rxjs.of(acc + one), seed1),
);
count$1.subscribe(x => console.log('scan: '+x));