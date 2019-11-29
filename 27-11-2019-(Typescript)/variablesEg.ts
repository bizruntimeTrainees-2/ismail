
 function f() {
    var a = 1;

    a = 2;
    var b = g();
    a = 3;

    return b;

    function g() {
        return a;
    }
}


let tuple: [number, string, boolean] = [7, "hello", true];
let [a, b, c] = tuple;

console.log(a);
console.log(b);
console.log(c);
     console.log(f());
   
}

