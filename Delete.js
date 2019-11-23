      function Delete()
      {
        var  xhr = new XMLHttpRequest();
        xhr.onreadystatechange=function(){
          if(xhr.status==200&& xhr.readyState==4)
          {
            var d =  document.getElementById("show");
           d.innerHTML = xhr.responseText;
           d.style="show";
          }
        };
        var data = "This is delete data";
        xhr.open("DELETE","Delete",true);
        xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
        xhr.send(data);
      }
         