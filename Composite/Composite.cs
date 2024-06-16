namespace Composite;

internal class Composite : Component
{
    private readonly List<Component> _children;

    public Composite(string name) : base(name)
    {
        _children = [];
    }
    public override void Add(Component component)
    {
        _children.Add(component);
    }
    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{new String('-', depth)}{name}");
        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }


}
