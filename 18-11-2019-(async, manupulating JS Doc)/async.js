document.addEventListener("click", () =>
	{
		let mydate;
		for (let i = 0; i < 10000 ; i++ )
		{
              		let date  = new Date();
            mydate = date;
		}
		
		document.getElementById("pa").innerHTML = mydate;
		let pEle =  document.createElement("p");
		pEle.textContent = "this is newly added text";
		document.body.appendChild(pEle);
		});