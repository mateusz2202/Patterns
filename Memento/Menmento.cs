using Memento.Models;

namespace Memento;

internal class Menmento
{
    public Product Product { get; }

    public Menmento(Product product)
    {
        Product = product;
    }

    public override string ToString()
    {
        return $"Memento: {Product.ToString()}";
    }
}
