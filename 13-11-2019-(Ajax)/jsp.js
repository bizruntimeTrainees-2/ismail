function myFunction(){
loadFile("ajax.txt", 2000, showMessage, "new message!\n");
function showMessage(message)
{
	console.log(message + this.responseText)
}
function loadFile(url, timeout, callback)
{
	var args = Arrays.prototype.slice.call(arguments,3);
	var xhr = new XMLHttpRequest();
	var.ontimeout = function()
	{
		console.error("the request for"+ url+"timed out.");
	}
	xhr.onload = function()
	{
		if(xhr.readyState==4 && xhr.status==200)
		{
			callback.apply(xhr, args)
		}
		esle
		{
			console.error(xhr.statusText);
		}
	};
	xhr.open("GET", url, true);
	xhr.timeout = timeout;
	xhr.send();
}