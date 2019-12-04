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
var tuple = [7, "hello", true];
var a = tuple[0], b = tuple[1], c = tuple[2];
console.log(a);
console.log(b);
console.log(c);
console.log(f());
