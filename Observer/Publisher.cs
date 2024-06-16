namespace Observer;

internal class Publisher
{
    private readonly List<ISubscriber> _subscribers;

    public Publisher()
    {
        _subscribers = [];
    }

    public void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
            subscriber.Update(message);
    }

    public void Subscribe(ISubscriber subscriber)
    {
        if (_subscribers.Contains(subscriber)) return;

        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers?.Remove(subscriber);
    }
}
