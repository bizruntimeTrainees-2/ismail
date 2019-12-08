import { Observable} from 'rxjs';

var observable = Observable.create((observer:any) => {
    observer.next("hello world");
});

observable.subscribe(
    (x:any) => console.log(x)
);