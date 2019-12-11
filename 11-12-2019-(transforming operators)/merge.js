
const  letters = rxjs.of('a','b','c');
const results1 = letters.pipe(
       rxjs.operators.mergeMap(x => rxjs.interval(500).pipe( rxjs.operators.map(i => x +': '+i)))
	   );

	  var sub=  results1.subscribe(x => console.log(x));

	  setTimeout(() =>{
	   sub.unsubscribe();
	  }, 5000
	  )

 const clicks2 = rxjs.fromEvent(document, 'click');
const higherOrder = clicks2.pipe(rxjs.operators.map((ev) => rxjs.interval(1000).pipe(rxjs.operators.take(5))));
const firstOrder = higherOrder.pipe(rxjs.operators.mergeAll(2));
var sub1 = firstOrder.subscribe(x => console.log('mergeall: '+x));

  