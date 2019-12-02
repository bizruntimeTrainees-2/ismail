/*
iterators and generators
for..of and for..each
*/
var list = [10, 20, 30];
for (var item in list) {
    console.log(item); // it will print indexes of items
}
for (var _i = 0, list_1 = list; _i < list_1.length; _i++) {
    var item = list_1[_i];
    console.log(item); // it will print items
}
var books = ["physics", "maths", "science"];
books["C"] = "language";
for (var book in books) {
    console.log(book); // it will print indexes of items
}
for (var _a = 0, books_1 = books; _a < books_1.length; _a++) {
    var book = books_1[_a];
    console.log(book); // it will print items
}
