using AbstractFactory.UIElements;

namespace AbstractFactory.Platforms.Mac.UIElements.UIelements;

internal class TextBox : ITextbox
{
    public async Task Render()
    {
        await Task.Delay(2000);
        Console.WriteLine($"Rendering {nameof(TextBox)} on Mac");
    }
}
