var num1 = 1;
function letDeclaration() {
    var num2 = 2;
    if (num2 > num1) {
        var num3 = 3;
        num3++;
    }
    while (num1 < num2) {
        var num4 = 4;
        num1++;
    }
    console.log(num1);
    console.log(num2);
    //console.log(num3); //let variables is limited to their containing block
    //console.log(num4);
}
letDeclaration();
/*
let num1: number = 1;
function varDeclaration() {
    var num2: number = 2;

    if (num2 > num1) {
        var num3: number = 3;
        num3++;
    }
    while (num1 < num2) {
        var num4: number = 4;
        num1++;
    }
    console.log(num1);//1
    console.log(num2);//2
    console.log(num3);//3
    console.log(num4);//4
}
letDeclaration();




let num:number = 1;
function demo() {
    let num:number = 2;
    if(true) {
        let num:number = 3;
        console.log(num); //3
    }
    console.log(num);//2
}
console.log(num); //1



function letDemo(a: number) {
    let a: number = 10; //Compiler Error: TS2300: Duplicate identifier 'a'
    let b: number = 20;
        return a + b;

const num:number=100;
num=200//error
*/ 
//# sourceMappingURL=variables.js.map