using Strategy.Models;

namespace Strategy;

internal class Map(IRouteStrategy routeStrategy, Route route)
{
    public Route Route { get; } = route;
    public void CreateRoute()
        => routeStrategy.CreateRoute(route.Start, route.End);

}
