using AbstractFactory.UIElements;

namespace AbstractFactory.Platforms.Windows.UIElements;

internal class Button : IButton
{
    public async Task Render()
    {
        await Task.Delay(3000);
        Console.WriteLine($"Rendering {nameof(Button)} on Windows");
    }
}
