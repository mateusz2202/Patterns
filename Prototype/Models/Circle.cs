namespace Prototype.Models;

internal class Circle : Shape
{
    public int Z { get; set; }

    public override void Render()
    {
        Console.WriteLine($"Rendering {this.GetType().Name}: ({X},{Y},{Z})");
        Border?.Render();
    }
    
}
