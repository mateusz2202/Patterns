using Strategy;
using Strategy.Models;


var mapManager = new MapManager(new MapFacotry());
var route = new Route(new Coordinate(5, 4), new Coordinate(10, 16));

foreach (var map in mapManager.GetMaps(route))
	map.CreateRoute();





