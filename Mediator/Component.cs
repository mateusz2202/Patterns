namespace Mediator;

internal class Component
{
    protected IMediator mediator;

    public void SetMediator(IMediator mediator)
    {
        this.mediator = mediator;
    }
}
