
rxjs.of(
  {id: 1, name: 'JavaScript'},
  {id: 2, name: 'Parcel'},
  {id: 2, name: 'webpack'},
  {id: 1, name: 'TypeScript'},
  {id: 3, name: 'TSLink'}
).pipe(
  rxjs.operators.groupBy(p => p.id),
  rxjs.operators.mergeMap((group$) => group$.pipe(rxjs.operators.reduce((acc, cur) => [...acc, cur], []))),
)
.subscribe(p => console.log(p));


rxjs.of(
  {id: 1, name: 'JavaScript'},
  {id: 2, name: 'Parcel'},
  {id: 2, name: 'webpack'},
  {id: 1, name: 'TypeScript'},
  {id: 3, name: 'TSLink'}
).pipe(
  rxjs.operators.groupBy(p => p.id, p => p.name),
  rxjs.operators.mergeMap(group$ =>
        group$.pipe(rxjs.operators.reduce((acc, cur) => [...acc, cur],[ group$.key] ))
  ),
  rxjs.operators.map( arr => ({ id: parseInt(arr[0],10), values: arr.slice(1) }))
  ).subscribe(p => console.log(p));
