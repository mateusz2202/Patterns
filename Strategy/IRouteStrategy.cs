using Strategy.Models;

namespace Strategy;

internal interface IRouteStrategy
{
    void CreateRoute(Coordinate start, Coordinate end);
}
