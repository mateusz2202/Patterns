using Visitor.Helpers;

namespace Visitor;

internal class ValidatorA : IVisitor
{
    public void Visit(IElement element)
    {
        if (element is Node node)
        {
            if (node.Name.Contains("a") || node.Name.Contains("b"))
                $"Node {node.Name} is not valid ".WirteLineColor(ConsoleColor.Red);
            else
                $"Node {node.Name} is not valid ".WirteLineColor(ConsoleColor.Green);
        }
    }
}
