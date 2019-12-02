/*
iterators and generators
for..of and for..each
*/

let list = [10,20,30];
for(let item in list)
{
console.log(item); // it will print indexes of items
}
for(let item of list)
{
console.log(item);// it will print items
}

let books = ["physics","maths","science"];
books["C"] ="language";

for(let book in books)
{
console.log(book); // it will print indexes of items
}
for(let book of books)
{
console.log(book);// it will print items
}