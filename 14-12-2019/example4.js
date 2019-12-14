

/*

var input = document.querySelector('input');
var observable = Rx.Observable.of(1,2,3,4,5);

observable
.subscribe({
	next: function(value) {
  	console.log(value);
  }
});
*/


var observable = Rx.Observable.of(1,2,3,4,5);

observable
//scan() -> 1,3,6,10,15
//reduce() -> 15
.scan((total, currentValue) => {   
	return total + currentValue;
}, 0)
.subscribe({
	next: function(value) {
  	console.log(value);
  }
});