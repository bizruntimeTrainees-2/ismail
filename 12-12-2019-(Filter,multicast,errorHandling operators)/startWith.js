//startwith

//First emits its arguments in order, and then any emissions from the source.

rxjs.of(["from source"])
  .pipe(rxjs.operators.startWith("first", "second","third"))
  .subscribe(x => console.log('startWith: ',x));
