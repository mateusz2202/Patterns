using Prototype.Models;

var c1 = new Circle
{
    X = 5,
    Y = 10,
    Z=6,
    Border = new Border
    {
        Thickness = 10,
        X = 5,
        Y = 10,
    }
};

var c2 = c1.Clone() as Circle;

c1.Render();
Console.WriteLine("===============================");
c2.Render();


