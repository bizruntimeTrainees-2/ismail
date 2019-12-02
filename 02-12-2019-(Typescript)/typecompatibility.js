var x;
var y = { name: "company", location: "bangulore" };
x = y; // it works
var x1 = function (a) { return 0; };
var y1 = function (b, s) { return 0; };
y1 = x1; //it works
// x1= y1;//it gives error bcz x doesn't contain string type in it
var items = [10, 20, 30];
items.forEach(function (item, index, items) { return console.log(item); }); // it is so long process
items.forEach(function (item) { return console.log(item); });
var x2 = function () { return ({ name1: "company" }); };
var y2 = function () { return ({ name1: "birzruntime", location1: "bangulore" }); };
x2 = y2; //its error bcz location return type property is not available in x2 
//y2 = x2;//it works
function invokeLater(args, callback) {
}
invokeLater([1, 2], function (x, y) { return console.log(x + ", " + y); });
invokeLater([1, 2], function (x, y) { return console.log(x + ", " + y); });
//enums
var Status;
(function (Status) {
    Status[Status["Ready"] = 0] = "Ready";
    Status[Status["Waiting"] = 1] = "Waiting";
})(Status || (Status = {}));
;
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Blue"] = 1] = "Blue";
    Color[Color["Green"] = 2] = "Green";
})(Color || (Color = {}));
;
var d = Status.Ready;
var x4;
var y4;
x4 = y4; // OK, because y matches structure of x
//x4 = y4; it is error when changes occured in  Empty<T>
