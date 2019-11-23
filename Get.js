
function SendRequest()
{
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
      document.getElementById("show").innerHTML = xhr.responseText;
    }
  };
  xhr.open("GET","get?foo1=bar1&foo2=bar2",true);
  xhr.send();
}

function addText()
{

var element = document.createElement("input");
element.setAttribute("type","text");
 var add = document.getElementById("add");
 add.appendChild(element);       
}
function addText1()
{

var element = document.createElement("input");
element.setAttribute("type","text");
 var add1 = document.getElementById("add1");
 add1.appendChild(element);       
}
