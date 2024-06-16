namespace Bridge.Models;

internal class Circle(IInteractionBehaviour interactionBehaviour, double radius) : Shape(interactionBehaviour)
{
    public double Radius { get => radius; }

    public override void Render()
    {
        Console.WriteLine($"Rendering {this.GetType().Name}: ({X},{Y},{Radius})");
        Border?.Render();
    }
}
