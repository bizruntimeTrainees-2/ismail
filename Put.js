function Put()
{
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
      document.getElementById("show").innerHTML = xhr.responseText;
    }
  };
  var data = "This is put data";
  xhr.open("PUT","put",true);
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.send(data);
}