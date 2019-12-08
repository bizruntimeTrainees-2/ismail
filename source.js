import $ from 'jquery';
import Rx from 'rxjs/Rx';

const source$ = new Rx.Observable( observer =>{
    console.log('createing Observable');
    observer.next('Hello World');
    observer.next('another value');

    setTimeout(() => {
        observer.next('Yet another value');
        observer.complete();       
    }, 3000);
});
source$.subscribe(
    x => {
        console.log(x);
    },
    err =>{
        console.log(err);
    },
    complete => {
        console.log('completed');
    });

    source$
    .catch(err => Rx.Observable.of(err))
    .subscribe(
        x => {
            console.log(x);
        },
        err =>{
            console.log(err);
        },
        complete => {
            console.log('completed');
        });
