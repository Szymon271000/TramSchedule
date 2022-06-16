using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramScheduleData.Context;
using TramScheduleData.Model;
using TramScheduleData.UngenericRepository;

namespace TramScheduleLogic
{
    public class RouteHandler
    {
        private RouteRepository _routeRepository;
        private IInputSystem _inputSystem;

        public RouteHandler()
        {
            _routeRepository = new RouteRepository();
            _inputSystem = new ConsoleInputSystem();
        }

        public RouteHandler(RouteRepository routeRepository, IInputSystem inputSystem)
        {
            _routeRepository = routeRepository;
            _inputSystem = inputSystem;
        }

        public Route Add()
        {
            string name = _inputSystem.FetchStringValue("Name of the route");
            var route = new Route(name);
            _routeRepository.Insert(route);
            _routeRepository.Save();
            return route;
        }

        public void AddStop(Route route, Stop stop)
        {
            route.Stops.Add(stop);
            _routeRepository.Save();
        }
    }
}
