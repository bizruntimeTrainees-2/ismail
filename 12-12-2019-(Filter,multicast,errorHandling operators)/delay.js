
const clicks9 = rxjs.fromEvent(document, 'click');
const date = new Date('December 12, 2019 10:59:00'); // in the future
const delayedClicks = clicks9.pipe(rxjs.operators.delay(date));
// click emitted only after that date
delayedClicks.subscribe(x => console.log(x));
