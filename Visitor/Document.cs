namespace Visitor;

internal class Document
{

    private readonly List<Node> _nodes;

    public Document()
    {
        _nodes = new List<Node>();
    }

    public Node AddNode(string name)
    {
        var node = new Node(name);
        _nodes.Add(node);
        return node;
    }

    public void Validation(IVisitor visitor)
    {
        foreach (var node in _nodes)        
            visitor.Visit(node);        
    }

}


