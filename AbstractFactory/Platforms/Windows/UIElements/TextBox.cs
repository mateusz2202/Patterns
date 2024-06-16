using AbstractFactory.UIElements;

namespace AbstractFactory.Platforms.Windows.UIElements;

internal class TextBox : ITextbox
{
    public async Task Render()
    {
        await Task.Delay(3000);
        Console.WriteLine($"Rendering {nameof(TextBox)} on Windows");
    }
}
