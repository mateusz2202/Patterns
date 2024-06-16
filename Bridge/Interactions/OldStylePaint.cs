using Bridge.Models;

namespace Bridge.Interactions;

internal class OldStylePaint : IInteractionBehaviour
{
    public void Interact()
    {
        Console.WriteLine($"{GetType().Name}");
    }
}
