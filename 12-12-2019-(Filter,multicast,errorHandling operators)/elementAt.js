
const clicks10 = rxjs.fromEvent(document, 'click');
const result10 = clicks10.pipe(rxjs.operators.elementAt(2));
//emit that at a specified element
result10.subscribe(x => console.log('elementAt(2): ',x));