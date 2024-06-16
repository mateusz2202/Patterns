using AbstractFactory.Platforms.Windows.UIElements;
using AbstractFactory.UIElements;

namespace AbstractFactory.Factories;

internal class WindowsFactory : IUIElementFacotry
{
    public IButton CreateButton()
    {
        return new Button();
    }

    public ITextbox CreateTextBox()
    {
        return new TextBox();
    }
}
