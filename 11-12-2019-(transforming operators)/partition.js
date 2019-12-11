

const clicks5 = rxjs.fromEvent(document, 'click');
const parts = clicks5.pipe(rxjs.operators.partition(ev => ev.target.tagName === 'DIV'));
const clicksOnDivs = parts[0];
const clicksElsewhere = parts[1];
clicksOnDivs.subscribe(x => console.log('DIV clicked: ', x));
clicksElsewhere.subscribe(x => console.log('Other clicked: ', x));