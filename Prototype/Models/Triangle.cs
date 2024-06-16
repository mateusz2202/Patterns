namespace Prototype.Models;
internal class Triangle : Shape
{
    public override void Render()
    {
        Console.WriteLine($"Rendering {this.GetType().Name}: ({X},{Y})");
    }
}

