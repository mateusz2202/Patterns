namespace Observer;

internal class Subscriber(string name) : ISubscriber
{
    public void Update(string meesage)
    {
        Console.WriteLine($"{name}: pick up message: {meesage}");
    }
}
