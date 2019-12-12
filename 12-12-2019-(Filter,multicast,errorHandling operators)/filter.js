//fiter
//emits only when clicked on div
const clicks11 = rxjs.fromEvent(document, 'click');
const clicksOnDivs = clicks11.pipe(rxjs.operators.filter(ev => ev.target.tagName === 'DIV'));
clicksOnDivs.subscribe(x => console.log('fiter: ',x));

//ignore elements
rxjs.of('you', 'talking', 'to', 'me').pipe(
  rxjs.operators.ignoreElements(),
)
.subscribe(
  word => console.log(word),
  err => console.log('error:', err),
  () => console.log('the end'),
);