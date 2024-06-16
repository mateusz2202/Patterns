using Strategy.Enums;
using Strategy.Models;

namespace Strategy;

internal class MapManager(MapFacotry mapFacotry)
{
    public IEnumerable<Map> GetMaps(Route route)
    {
        foreach (MapType type in Enum.GetValues(typeof(MapType)))
            yield return mapFacotry.Create(type, route);
    }
}
