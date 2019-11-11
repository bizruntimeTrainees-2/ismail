function createXHR()
	{
		var	xhr =new XMLHttpRequest();
	xhr.onreadystatechange = function (){
		if (xhr.readyState == 4 && xhr.status == 200)
		{
				document.getElementById("dyn").innerHTML =  xhr.responseText;
		}
		else
			window.alert("file or page not found");
	};
	xhr.open("POST", "ajax.php", true);
	xhr.setRequestHeader("Content-type","application/x-www-form-urlencoded");
	xhr.send("name= ismail");
	}