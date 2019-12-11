const  source = rxjs.fromEvent(document,'click');
const result = source.pipe(
                            rxjs.operators.concatMap( ev => rxjs.interval(1000).pipe(rxjs.operators.take(4)))
							);

 const subscription = result.subscribe(
 										function(x) { console.log('Next: '+ x);},
 										function(err) { console.log('Error: '+ err);},
 										function() { console.log('completed');});
/*
const result = source.pipe(
                            rxjs.operators.concatMapTo( rxjs.interval(1000).pipe(rxjs.operators.take(4)))
							);

 const subscription = result.subscribe(
 										function(x) { console.log('Next: '+ x);},
 										function(err) { console.log('Error: '+ err);},
 										function() { console.log('completed');});
*/