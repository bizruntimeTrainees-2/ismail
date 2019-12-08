import $ from 'jquery';
import Rx from 'rxjs/Rx';

const btn = $('#btn');
const input = $('#input');
const output =$('#output');
const btnStream$ = Rx.Observable.fromEvent(btn, 'click');

btnStream$.subscribe(
    function(e){
       Console.log('Clicked');
},
function(err){
    Console.log(err);
},
function(){
    Console.log('Completed');
});
const inputStream$ = Rx.Observable.fromEvent(input, 'keyup');

inputStream$.subscribe(
    function(e){
       Console.log(e.currentTarget.value);
       output.append(e.currentTarget.value);
},
function(err){
    Console.log(err);
},
function(){
    Console.log('Completed');
});

const moveStream$ = Rx.Observable.fromEvent(document, 'mousemove');

moveStream$.subscribe(
    function(e){
       Console.log(e.currentTarget.value);
       output.html('<h2>'+'X: '+e.ClientX+'Y: '+ e.ClientY+'</h2>');
},
function(err){
    Console.log(err);
},
function(){
    Console.log('Completed');
});

const numbers = [33,44,55,66,77];
const numbers$ = Rx.Observable.from(numbers);

numbers$.subscribe(
    x => {
        console.log(x);
    },
    err => {
        console.log(err);
    },
    complete => {
        console.log('completed');
    });

    const posts = [
        {title:'post one', body:'this is body'},
        {title:'post two', body:'this is body'},
        {title:'post three', body:'this is body'}
  ]
  const postOutput = $('#posts');
  const posts$ = Rx.Observable.from(posts);
  posts$.subscribe(
    post => {
        console.log(post);
        $('#posts').append('<li><h3>'+post.title+'</h3></li>');
    },
    err => {
        console.log(err);
    },
    complete => {
        console.log('completed');
    });

    const set = new Set(['Hello', 44,{title:'My tite'}]);
    const set$ = Rx.Observable.from(set);
    set$.subscribe(
        v => {
            console.log(v);
        },
        err => {
            console.log(err);
        },
        complete => {
            console.log("completed");
        });

        const map = new Map([[1,2], [3,4],[5,6]]);
        const map$ = Rx.Observable.from(map);
        map$.subscribe(
            v => {
                console.log(v);
            },
            err => {
                console.log(err);
            },
            complete => {
                console.log("completed");
            }
        );

        