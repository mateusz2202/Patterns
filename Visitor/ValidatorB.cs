using Visitor.Helpers;

namespace Visitor;

internal class ValidatorB : IVisitor
{
    public void Visit(IElement element)
    {
        if (element is Node node)
            $"Valid {node.Name}".WirteLineColor(ConsoleColor.Green);
    }
}
