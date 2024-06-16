using Singleton;

static async Task Test()
{
    var config = Configuration.GetConfiguration();
    await Task.CompletedTask;
};

Thread process1 = new Thread(async () =>
{ 
    await Test();
});
Thread process2 = new Thread(async () =>
{
    await Test();
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();


Console.WriteLine(Counter.Value);
