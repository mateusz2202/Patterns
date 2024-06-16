namespace Bridge.Models;

internal class Triangle(IInteractionBehaviour interactionBehaviour) : Shape(interactionBehaviour)
{
    public override void Render()
    {
        Console.WriteLine($"Rendering {this.GetType().Name}: ({X},{Y})");
        Border?.Render();
    }
}
