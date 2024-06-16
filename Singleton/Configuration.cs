namespace Singleton;


public static class Counter
{
    public static int Value { get; set; } = 1;
}
public class Configuration
{
    public string ParameterFirst { get; set; }
    public string ParameterSecond { get; set; }

    private static Configuration _configuration;
    private static readonly object _lock = new object();

    private Configuration() { }

    public static Configuration GetConfiguration()
    {
        if (_configuration is null)
        {
            lock (_lock)
            {
                if (_configuration is null)
                {
                    _configuration = new Configuration();

                    Counter.Value++;
                }
            }
        }
          

        return _configuration;
    }
}
