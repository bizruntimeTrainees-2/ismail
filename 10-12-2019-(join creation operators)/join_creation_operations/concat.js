const timer1 = rxjs.interval(1000).pipe(rxjs.operators.take(4));
const timer2= rxjs.interval(1000).pipe(rxjs.operators.take(6));
const sequence = rxjs.range(1,10);
const result = rxjs.concat(timer1,timer2, sequence);
result.subscribe( x => addItem(x));

function addItem(val){
    const item = document.getElementById('items');
    const li = document.createElement('li');
    const text = document.createTextNode(val);
     li.appendChild(text);
    item.appendChild(li)
}