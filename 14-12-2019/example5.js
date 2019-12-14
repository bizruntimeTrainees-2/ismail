/*
var input = document.querySelector('input');
var observable = Rx.Observable.fromEvent(input, 'input');

observable
.subscribe({
	next: function(event) {
  	console.log(event.target.value);
  }
});
*/



var input = document.querySelector('input');
var observable = Rx.Observable.fromEvent(input, 'input');

observable
//pluck ->target: gives target of the event, value: as many arg  we want  to extract
.pluck('target', 'value')
.debounceTime(500)
.distinctUntilChanged()
.subscribe({
	next: function(value) {
  	console.log(value);
  }
});

