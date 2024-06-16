using AbstractFactory.Platforms.Mac.UIElements.UIelements;
using AbstractFactory.UIElements;

namespace AbstractFactory.Factories;

internal class MacFactory : IUIElementFacotry
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
