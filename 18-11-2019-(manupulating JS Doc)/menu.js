function init(){
	var tec = document.getElementById("tec");
	var i , li, newAnchor;
	for (i = 0; i < document.anchors.length ; i++)
	{
		li = document.createElement("li");
		newAnchor = document.createElement("a");
		newAnchor.href = document.anchors[i].name;
		newAnchor.innerHTML = document.anchors[i].text;
		li.appendChild(newAnchor);
		tec.appendChild(li);
	}
}