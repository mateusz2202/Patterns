namespace Mediator.Compontens;

internal class Checkbox : Component
{
    public void Select()
    {
        Console.WriteLine("checkbox selected");
        this.mediator.Notify(this, "checkBoxSelected");
    }

    public void SaveValue()
    {
        Console.WriteLine("SaveValue");
    }
}
