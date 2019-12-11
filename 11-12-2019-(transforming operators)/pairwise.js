

const clicks3 = rxjs.fromEvent(document, 'click');
const pairs = clicks3.pipe(rxjs.operators.pairwise());
const distance = pairs.pipe(
  rxjs.operators.map(pair => {
    const x0 = pair[0].clientX;
    const y0 = pair[0].clientY;
    const x1 = pair[1].clientX;
    const y1 = pair[1].clientY;
    return Math.sqrt(Math.pow(x0 - x1, 2) + Math.pow(y0 - y1, 2));
  }),
);
distance.subscribe(x => console.log('pairwise: '+x));