let socket = new WebSocket(" https://developer.mozilla.org/en-US/docs/Web/API/WebSockets_API");//url just taken as reference

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