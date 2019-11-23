
function PostFormData()
{
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
      document.getElementById("show").innerHTML = xhr.responseText;
    }
  };
  var data = "foo1=bar1&foo2=bar2";
  xhr.open("POST","post",true);
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.send(data);
}