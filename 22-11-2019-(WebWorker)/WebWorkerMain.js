function Init()
{
const first = document.getElementById("first");
const second= document.getElementById("second");
var fullname = document.getElementById("demo");

if(window.Worker)
{
    var myWork = new Worker("E:\New folder (2)\ismail\22-11-2019-(WebWorker)\worker.js");
    
    first.onchange= function()
    {
          myWork.postMessage([first.value,second.value]);
          Console.log("first message sent to worker");
    }
    second.onchange= function()
    {
          myWork.postMessage([first.value,second.value]);
          Console.log("second message sent to worker");
    }
    myWork.onmessage = function(e)
    {
        fullname.textContent = e.data;
        Console.log("Message received from worker");
    }
}
 else
 {
     Console.log("the file is not found"); 
 }
}
