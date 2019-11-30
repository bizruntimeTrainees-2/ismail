function CreateSquare(config) { color: string; area: number; }
{
    var newSquare = { color: "red", width: 50 };
    if (config.color) {
        newSquare.color = config.color;
        console.log(newSquare.color);
    }
    if (config.width) {
        newSquare.width = config.width * config.width;
        console.log(newSquare.width);
    }
    return newSquare;
}
var mySquare = CreateSquare({ color: "black", width: 20 });
