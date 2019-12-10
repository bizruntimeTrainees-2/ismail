



var source = rxjs.defer(function () {
    return rxjs.of(42);
});

var subscription = source.subscribe(
    function (x) { console.log('Next: ' ,x); },
    function (err) { console.log('Error: {0}' , err); },
    function () { console.log('Completed'); } );

    
const users = rxjs.ajax({
  url: 'https://httpbin.org/delay/2',
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
    'rxjs-custom-header': 'Rxjs'
  }
}).pipe(
  map(response => console.log('response: '+ response)),
  catchError(error => {
    console.log('error:  ', error);
    return of(error);
  })
);

const obs$ = ajax.getJSON(`https://postman-echo.com/get`).pipe(
  map(userResponse => console.log('users: ', userResponse)),
  catchError(error => {
    console.log('error: ', error);
    return of(error);
  })
);
var subscription = obs$.subscribe(
  function (x) { console.log('Next: ' ,x); },
  function (err) { console.log('Error: {0}' , err); },
  function () { console.log('Completed'); } );