namespace Prototype.Models;

internal class Border : IBorder
{
    public int Thickness { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public IRender Clone()
    {
        return MemberwiseClone() as IBorder;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering {GetType().Name}: ({X},{Y}), {nameof(Thickness)}:{Thickness}");
    }
}
