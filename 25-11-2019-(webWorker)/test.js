function generateWords(num)
{ 
	var test = "the data from the worker and this  is worker example";
	var words = test.split(" ");
    var word = "";

	for (var i =0; i < num ; i++ )
	{
		var rand = parseInt(Math.random() * words.length);
		word += " "+ words(rand);
	}
	return word;
	}

	self.onmessage = function (event) {
		var word = generateWords(event.data.num);
		self.postMessage({test: word});
	}