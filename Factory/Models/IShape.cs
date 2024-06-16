namespace Factory.Models;

public interface IShape
{
    public int X { get; set; }
    public int Y { get; set; }

    void Render();
}
