interface InterClass
{
         color?:string,
        width?: number
}
    function CreateSquare(config: InterClass){ color:string; area: number}
    {
        let newSquare = {color: "red"; width: 50};
        if (config.color)
        {
            newSquare.color = config.color;
	    console.log(newSquare.color);
        }
        if(config.width)
        {
           newSquare.width = config.width * config.width;
	   console.log( newSquare.width);
        }
        return newSquare;
    }
    let mySquare = CreateSquare({color: "black", width: 20});