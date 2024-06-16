using AbstractFactory.Enums;
using AbstractFactory.Factories;

namespace AbstractFactory;

internal class Application
{
    private readonly IUIElementFacotry _uIElementFacotry;

    public Application(IUIElementFacotry uIElementFacotry)
    {
        _uIElementFacotry = uIElementFacotry;
    }

    private async Task RenderUI()
    {
        await _uIElementFacotry.CreateTextBox().Render();
        await _uIElementFacotry.CreateTextBox().Render();
        await _uIElementFacotry.CreateButton().Render();
    }

    public async Task Run()
    {
        await RenderUI();
        Console.WriteLine("Application runned");
    }
}

internal class ApplicationFactory
{
    public Application Create(PlatformType platform) => platform switch
    {
        PlatformType.Windows => new Application(new WindowsFactory()),
        PlatformType.Mac => new Application(new MacFactory()),
        _ => throw new ArgumentException("Invalid enum value for plafrotm type", nameof(platform)),
    };
}

