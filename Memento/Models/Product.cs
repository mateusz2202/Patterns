namespace Memento.Models;

internal record Product(string Name, decimal Price)
{
    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}";
    }    
}
