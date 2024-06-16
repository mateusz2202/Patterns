namespace Prototype.Models;

internal class Rectangle : Shape
{
    public override void Render()
    {
        Console.WriteLine($"Rendering {this.GetType().Name}: ({X},{Y})");
    }
}