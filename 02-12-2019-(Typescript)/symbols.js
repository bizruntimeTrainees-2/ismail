var _a;
/*
Symbols:
>>symbol is primitive data type and symbol values are created by calling Symbol constructor
>>symbols are immutable and unique
>>Just like strings, symbols can be used as keys for object properties.
*/
var sym1 = Symbol();
var sym2 = Symbol("key");
var sym3 = Symbol("key");
console.log(sym2 == sym3); // false
var s1 = Symbol();
var obj = (_a = {},
    _a[s1] = "value",
    _a);
console.log(obj[s1]);
var getClassName = Symbol();
var Ex = /** @class */ (function () {
    function Ex() {
    }
    Ex.prototype[getClassName] = function () {
        return "Ex";
    };
    return Ex;
}());
var ex = new Ex();
var className = ex[getClassName]();
console.log(className);
/*
important well-known list of symbols

Symbol.hasInstance:
A method that determines if a constructor object recognizes an object as one of the constructor’s instances.called by instanceof operator

Symbol.isConcatSpreadable:
A Boolean value indicating that an object should be flattened to its array elements by Array.prototype.concat.

Symbol.iterator:
A method that returns the default iterator for an object. Called by the semantics of the for-of statement.

Symbol.match :
A regular expression method that matches the regular expression against a string. Called by the String.prototype.match method.

Symbol.replace:
A regular expression method that replaces matched substrings of a string. Called by the String.prototype.replace method.

Symbol.search:
A regular expression method that returns the index within a string that matches the regular expression. Called by the String.prototype.search method.

Symbol.species :
A function valued property that is the constructor function that is used to create derived objects.

Symbol.split:
A regular expression method that splits a string at the indices that match the regular expression. Called by the String.prototype.split method.

Symbol.toPrimitive:
A method that converts an object to a corresponding primitive value. Called by the ToPrimitive abstract operation.

Symbol.toStringTag:
A String value that is used in the creation of the default string description of an object. Called by the built-in method Object.prototype.toString.

Symbol.unscopables:
An Object whose own property names are property names that are excluded from the ‘with’ environment bindings of the associated objects.










*/ 
