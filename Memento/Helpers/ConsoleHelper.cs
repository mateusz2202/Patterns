namespace Memento.Helpers;

public static class ConsoleHelper
{
    public static void WirteLineColor(this string text, ConsoleColor color)
    {
        var currentColor = Console.ForegroundColor;
        Console.ForegroundColor = color;

        Console.WriteLine(text);
        Console.ForegroundColor = currentColor;       
    }
}
