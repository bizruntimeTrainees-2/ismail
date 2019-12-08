import { ajax } from 'rxjs/ajax';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';



var md = Rx.Observable.fromEvent(document, 'mousedown').map(true);
var mu = Rx.Observable.fromEvent(document, 'mouseup').map(false);

var source = Rx.Observable.range(1, 3)
    .select(function (x, idx, obs) {
        return x * x;
    });

var subscription = source.subscribe(
    function (x) { console.log('Next: ' + x); },
    function (err) { console.log('Error: ' + err); },
    function () { console.log('Completed'); });


var source = Rx.Observable.defer(function () {
    return Rx.Observable.return(42);
});

var subscription = source.subscribe(
    function (x) { console.log('Next: ' + x); },
    function (err) { console.log('Error: ' + err); },
    function () { console.log('Completed'); } );


const obs$ = ajax.getJSON(`https://postman-echo.com`).pipe(
  map(userResponse => console.log('users: ', userResponse)),
  catchError(error => {
    console.log('error: ', error);
    return of(error);
  })
);

const users = ajax({
  url: 'https://postman-echo.com',
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
    'rxjs-custom-header': 'Rxjs'
  },
  body: {
    rxjs: 'Hello World!'
  }
}).pipe(
  map(response => console.log('response: ', response)),
  catchError(error => {
    console.log('error: ', error);
    return of(error);
  })
);