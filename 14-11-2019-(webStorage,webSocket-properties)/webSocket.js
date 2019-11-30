let socket = new WebSocket(" wss://www.example.com/socketserver");//url just taken as reference

document.forms.myform.onsubmit= function ()  {
	let out = this.message.value;
	socket.send(out);
	return false;
};
socket.onmessage= function (event) {
	let message = event.data;
	let inp = document.createElement("div");
	inp.textContent = message;
	document.getElementById("messages").prepend(inp);	