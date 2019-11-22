onmessage=function(e)
{
    console.log('Worker: Message received from main script');
    let result = e.data[0]+" "+ e.data[1];
    if(isNaN(result))
    {
        this.postMessage('Please enter two fields');
    }
    else{
        let workerResult = "Full Name"+result;
        Console.log("message sent to main script");
        this.postMessage(workerResult);
    }
}