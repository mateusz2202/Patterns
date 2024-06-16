using AbstractFactory;
using AbstractFactory.Enums;

var applicationFactory = new ApplicationFactory();

var applicationMac = applicationFactory.Create(PlatformType.Mac);
var applicationWindows = applicationFactory.Create(PlatformType.Windows);

await Task.WhenAll(
    applicationWindows.Run(),
    applicationMac.Run()
    );






