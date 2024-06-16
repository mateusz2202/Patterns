using AbstractFactory.UIElements;

namespace AbstractFactory.Platforms.Mac.UIElements.UIelements;

internal class Button : IButton
{
    public async Task Render()
    {
        await Task.Delay(2000);
        Console.WriteLine($"Rendering {nameof(Button)} on Mac");
    }
}
