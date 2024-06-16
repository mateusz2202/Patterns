namespace Mediator.Compontens;

internal class Button : Component
{
    public void Render()
    {
        Console.WriteLine("Render button");
    }

    public void Click()
    {
        Console.WriteLine("Button click");
        this.mediator.Notify(this, "click");
    }
}
