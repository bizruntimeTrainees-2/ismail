
var input_id =2;

$(function(){
  $('#addButton').click(function(){
    $('#text1').clone().attr("id","text"+ ++input_id +$(this).index()).insertAfter('#text2') ;
  });
  $('#addButtonP').click(function(){
    $('#text1_1').clone().attr("id","text1_"+ ++input_id +$(this).index()).insertAfter('#text1_2') ;
  });
});

function SendRequest()
{
  var text = document.getElementById("text");
  var data='?';
  for(var i=0;i<text.children.length;i++)
       {
        if(text.children[i].id.includes("Text"))
        {
          data += text.children[i].id +'='+ text.children[i].value +'&';  
          data += data.value;       
        }  
      }
      
        data += text1.value + '&'+ text2.value;
       
    var xhr = new XMLHttpRequest();
    xhr.withCredentials = true;
    
    xhr.onreadystatechange=function(){
      if(xhr.readyState===4)
      {
        document.getElementById("show").innerHTML = xhr.responseText;
      }
    };
    xhr.open("GET","/get"+ data);
    xhr.setRequestHeader("cache-control", "no-cache");
    xhr.setRequestHeader("postman-token", "e5a83bba-0476-63f1-26ea-e2c3f389b22b");  
    xhr.send();
}


function PostData()
{
  var data = document.getElementById("post");
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
      document.getElementById("show").innerHTML = xhr.responseText ;
    } 
  };
  
  
  xhr.open("POST","/post");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.setRequestHeader("Accept", "*/*"); 
  xhr.setRequestHeader("cache-control", "no-cache");
  xhr.setRequestHeader("postman-token", "85640a1b-7f2c-463e-9f82-c788a101ecc6","0141b2e3-5e5e-42d7-847e-c960567850f0"); 
  xhr.send(data.value);
}

function PostFormData()
{
  var tap = document.getElementById("postForm");
  var datap='';
  for(var i=0;i<tap.children.length;i++)
       {
        if(tap.children[i].id.includes("Text"))
        {
          datap += tap.children[i].id +'='+ tap.children[i].value +'&';
        }
        else
        {
          datap += text1_1.value + '&'+ text1_2.value;
         }
      }
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
      document.getElementById("show").innerHTML = xhr.responseText;
    }
  };
  xhr.open("POST","/post");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.setRequestHeader("Accept", "*/*"); 
  xhr.setRequestHeader("cache-control", "no-cache"); 
  xhr.setRequestHeader("postman-token", "85640a1b-7f2c-463e-9f82-c788a101ecc6","0141b2e3-5e5e-42d7-847e-c960567850f0"); 
  xhr.send(datap);
}

function Put()
{
  var datapu = document.getElementById("put");
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200 && xhr.readyState==4)
    {
      document.getElementById("show").innerHTML = xhr.responseText;
    }
  };
  
  xhr.open("PUT","/put");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded"); 
  xhr.setRequestHeader("Accept", "*/*"); 
  xhr.setRequestHeader("cache-control", "no-cache");
  xhr.setRequestHeader("postman-token", "85640a1b-7f2c-463e-9f82-c788a101ecc6","0141b2e3-5e5e-42d7-847e-c960567850f0");  
  xhr.send(datapu.value);
}

function Patch()
{
  var datapa = document.getElementById("patch");
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200 && xhr.readyState==4)
    {
      
      document.getElementById("show").innerHTML = xhr.responseText;
    }
  };
  xhr.open("PATCH","/patch");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.send(datapa.value);
}
function Delete()
{
  var data = document.getElementById("delete");
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
      var d =  document.getElementById("show");
     d.innerHTML = xhr.responseText;
    }
  };

  xhr.open("DELETE","/delete");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.send(data.value);
}

function  Base_auth(userName, password)
{
    var tik = userName + ":" + password;
    var tok = btoa(tik);
    return "Basic" +tok;
}

function Auth()
{
    var userName = $("#user").val();
    var password = $("#pass").val();

    var auth = Base_auth(userName,password);
    var xhr = new XMLHttpRequest();
    xhr.withCredentials = true;
    xhr.onreadystatechange=function(){
        if(xhr.status==200&& xhr.readyState==4)
        {
          document.getElementById("show").innerHTML = xhr.responseText ;
        } 
      };
   xhr.open("GET","/basic-auth");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.setRequestHeader("cache-control", "no-cache");
  xhr.setRequestHeader("postman-token", "85640a1b-7f2c-463e-9f82-c788a101ecc6","0141b2e3-5e5e-42d7-847e-c960567850f0"); 
  xhr.send();
}