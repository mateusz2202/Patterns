using Memento.Helpers;
using Memento.Models;

namespace Memento;

internal class Originator
{
    private Product _product;

    public void SetState(Product product)
    {
        _product = product;
    }

    public Product CurrentState => _product;

    public Menmento SaveState()
    {
        return new Menmento(_product);
    }

    public void RestoreState(Menmento memento)
    {
        _product = memento.Product;
    }

    public void ShowCurrentState()
    {
        $"Current: {CurrentState.ToString()}".WirteLineColor(ConsoleColor.Green);       
    }

}
