using Bridge.Models;

namespace Bridge.Interactions;

internal class NewStylePaint : IInteractionBehaviour
{
    public void Interact()
    {
        Console.WriteLine($"{GetType().Name}");
    }
}
