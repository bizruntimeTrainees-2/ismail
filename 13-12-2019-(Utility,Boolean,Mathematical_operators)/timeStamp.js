
const clickWithTimestamp = rxjs.fromEvent(document, 'click').pipe(
  rxjs.operators.timestamp()
);

// Emits data of type {value: MouseEvent, timestamp: number}
clickWithTimestamp.subscribe(data => {
  console.log(data )
});