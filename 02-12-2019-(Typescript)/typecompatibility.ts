// Type compatibility
/*
Basic rule: for x ix compatable with y
if we are assigning x = y then x should have atleast the same member with same  type(name is not consider)
*/
interface Named
{
	name :string
}
let x : Named;
let y  = {name:"company", location:"bangulore"};
x=y;// it works


let x1 = (a: number) => 0;
let y1 = (b:number, s: string)=>0;
 y1=x1; //it works
// x1= y1;//it gives error bcz x doesn't contain string type in it
 
 let items = [10,20,30];
 items.forEach((item, index, items)=> console.log(item));// it is so long process
 items.forEach((item) => console.log(item));
 
 
 let x2 = () => ({name1: "company"});
 let y2 = () => ({name1:"birzruntime", location1:"bangulore"});
 
 x2 = y2;//it works
 //y2 = x2;// its error bcz location return type property is not available in x2 
 
 function invokeLater(args: any[], callback: (...args: any[]) => void) {
 }
invokeLater([1, 2], (x, y) => console.log(x + ", " + y));
invokeLater([1, 2], (x?, y?) => console.log(x + ", " + y));

//enums
enum Status { Ready, Waiting };
enum Color { Red, Blue, Green };
let d = Status.Ready;
//status = Color.Green; //it gives error as accessing from differ enum member to another enum

interface Empty<T> {
	//data:T;
}
let x4: Empty<number>;
let y4: Empty<string>;

x4 = y4;  // OK, because y matches structure of x
//x4 = y4; it is error when changes occured in  Empty<T>



