using Memento.Helpers;
using System.Text;

namespace Memento;

internal class Caretaker
{
    private readonly Stack<Menmento> _mementos;
    private readonly Originator _originator;

    public Caretaker(Originator originator)
    {
        _mementos = [];
        _originator = originator;
    }

    public void Save()
    {
        _mementos.Push(_originator.SaveState());
    }

    public void Undo()
    {
        "Undo".WirteLineColor(ConsoleColor.Cyan);

        if (_mementos.Count <= 1) return;

        _ = _mementos.Pop();

        _originator.RestoreState(_mementos.Pop());

        Save();
    }

    public void ShowChangeStack()
    {
        StringBuilder sb = new();

        sb.AppendLine("-------------------Memenots------------------");

        foreach (var item in _mementos)
            sb.AppendLine(item.Product.ToString());

        sb.AppendLine("---------------------------------------------");

        sb.ToString().WirteLineColor(ConsoleColor.Yellow);
    }
}
