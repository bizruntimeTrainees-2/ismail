import $ from 'jquery';
import Rx from 'rxjs/Rx';

const myPromise = new Promise((resolve, reject) => {
    console.log('creating promise');
    setTimeout(() => {
        console.log("Hello from promise");
    }, 3000);
});

myPromise.then(x => {
    console.log(x);
});

const source$ = Rx.Observable.fromPromise(myPromise);
source$.subscribe(x => console.log(x));

