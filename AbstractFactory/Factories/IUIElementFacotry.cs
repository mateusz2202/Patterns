using AbstractFactory.UIElements;
namespace AbstractFactory.Factories;

internal interface IUIElementFacotry
{
    IButton CreateButton();
    ITextbox CreateTextBox();
}
