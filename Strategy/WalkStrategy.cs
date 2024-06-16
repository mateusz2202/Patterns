using Strategy.Models;

namespace Strategy;

internal class WalkStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        if (start is null) throw new ArgumentNullException(nameof(start), "Start coordinate cannot be null.");

        if (end is null) throw new ArgumentNullException(nameof(end), "End coordinate cannot be null.");

        Console.WriteLine($"Create Route for {this.GetType().Name}, Start({start.X},{start.Y}) to End({end.X},{end.Y})");
    }
}
