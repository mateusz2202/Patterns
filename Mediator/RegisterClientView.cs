using Mediator.Compontens;

namespace Mediator;

internal class RegisterClientView : IMediator
{
    private Checkbox _clientType;
    private Button _submitButon;


    public RegisterClientView(Checkbox checkbox, Button button)
    {
        _clientType = checkbox;
        _submitButon = button;

        _submitButon.SetMediator(this);
        _clientType.SetMediator(this);
    }
    public void Notify(Component sender, string @event)
    {

        if (@event == "checkBoxSelected")
        {
            _submitButon.Render();
        }
        else if(@event == "click")
        {
            _clientType.SaveValue();
        }
    }
}
