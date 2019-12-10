
const clicks = rxjs.fromEvent(document, 'click');
const timer = rxjs.interval(1000);

const clicksOrTimer$  = rxjs.merge(clicks,timer)
    var subscription = clicksOrTimer$.subscribe( x => addItems(x) )
    setTimeout(() => {
        subscription.unsubscribe()}, 5000);
   
    function addItems(val)
    {
        const z = document.getElementById('items');
        const x = document.createElement('li');
        const y = document.createTextNode(val);
        x.appendChild(y);
        z.appendChild(x);
        console.log(val)  
    }

   