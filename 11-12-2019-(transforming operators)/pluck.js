const clicks6 = rxjs.fromEvent(document, 'click');
const tagNames = clicks6.pipe(rxjs.operators.pluck('target', 'tagName'));
tagNames.subscribe(x => console.log("pluck: "+x));