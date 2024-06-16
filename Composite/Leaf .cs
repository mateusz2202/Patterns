namespace Composite;

internal class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Add(Component component)
    {
        ;
    }
    public override void Remove(Component component)
    {
        ;
    }

    public override void Display(int depth) => Console.WriteLine($"{new String('-', depth)}{name}");


}
