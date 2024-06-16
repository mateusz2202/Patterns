namespace Mediator;

internal interface IMediator
{
    void Notify(Component sender, string @event);
}
