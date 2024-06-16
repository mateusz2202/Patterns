namespace Factory.Models;

internal class Circle : IShape
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Render()
    {
        Console.WriteLine($"Rendering {nameof(Circle)}: ({X},{Y})");
    }
}
