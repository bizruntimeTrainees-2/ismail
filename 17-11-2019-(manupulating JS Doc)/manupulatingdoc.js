function init() {
	 var toc = document.getElementById("toc");
	 var i, li, newAnchor;
	 for (i = 0; i < document.anchors.length ; i++ )
	 {
		 li = document.createElement("li");
		 newAnchor = document.createElement("a");
		 newAnchor.href = "#" + document.anchors[i].name;
		 newAnchor.innerHTML = document.anchors[i].text;
		 li.appendChild(newAnchor);
		 toc.appendChild(li);
	 }
	 }

