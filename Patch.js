
      function Patch()
      {
        var  xhr = new XMLHttpRequest();
        xhr.onreadystatechange=function(){
          if(xhr.status==200 && xhr.readyState==4)
          {
            document.getElementById("show").innerHTML = xhr.responseText;
          }
        };
        var data = "This is patch data";
        xhr.open("PATCH","patch",true);
        xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
        xhr.send(data);
      }