const obs1 = rxjs.interval(501).pipe(rxjs.operators.mapTo('fast one'));
const obs2 = rxjs.interval(500).pipe(rxjs.operators.mapTo('medium one'));
const obs3 = rxjs.interval(550).pipe(rxjs.operators.mapTo('slow one'));
 
var r = rxjs.race(obs3, obs1, obs2)
.subscribe(
  winner => console.log(winner)
);
