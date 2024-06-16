using Strategy.Enums;
using Strategy.Models;

namespace Strategy;

internal class MapFacotry
{

    public Map Create(MapType type, Route route)
    {
        return type switch
        {
            MapType.Car => new Map(new CarStrategy(), route),
            MapType.Walk => new Map(new WalkStrategy(), route),
            MapType.Bike => new Map(new BikeStrategy(), route),
            _ => throw new ArgumentException("Invalid enum value for map type", nameof(type)),
        };

    }
}
