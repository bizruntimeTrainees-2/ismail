var std = "bangulore is cool city";
var s = "java";
	document.writeln(std.charAt(15) + " ");
	document.writeln(std.charCodeAt(15) +" ");     //code of that index
		document.writeln(std.search("is")+ " ");
		document.writeln(std.lastIndexOf("c") +" ");
		document.writeln(std.match("cool") +" ");                 //not present return null
		document.writeln(std.slice(1,1)+" ");
		document.writeln(std.replace("cool", "pool")+" ");
		document.writeln(std.substr(4, 10)+" ");
		document.writeln(std.substring(4, 10)+" ");
		document.writeln(std.valueOf()+" ");

		var date = new Date();
		document.write(date.getDate() +"/"+date.getDay());



