namespace Visitor;

internal class Node(string name) : IElement
{
    public string Name { get => name; }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
