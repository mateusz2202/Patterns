namespace Factory.Models;

internal class Triagle : IShape
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Render()
    {
        Console.WriteLine($"Rendering {nameof(Triagle)}: ({X},{Y})");
    }
}
