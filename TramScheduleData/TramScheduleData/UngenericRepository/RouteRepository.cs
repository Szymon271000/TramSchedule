using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramScheduleData.Context;
using TramScheduleData.GenericRepository.Interface;
using TramScheduleData.Model;

namespace TramScheduleData.UngenericRepository
{
    public class RouteRepository : IGenericRepository<Route>
    {
        private readonly TramContext _tramContext;

        public RouteRepository()
        {
            _tramContext = new TramContext();
        }
        public List<Route> GetAll()
        {
            return _tramContext.Routes.ToList();
        }
        public void Insert(Route obj)
        {
            _tramContext.Routes.Add(obj);
        }
        
        public IEnumerable<Stop> GetAllTramStop(int index)
        {
            if (index <= 0) 
                return Enumerable.Empty<Stop>();
            var line = GetTramLineWithStops(index);
            return line.Stops;
        }
        public Route GetTramLineWithStops(int id)
        {
            return _tramContext.Routes.Include(x=> x.Stops).AsNoTracking().Where(x=> x.RouteId == id).SingleOrDefault();
        }

        public Route GetRouteByName(string name)
        {
            return _tramContext.Routes.AsNoTracking().Where(x => x.Name == name).SingleOrDefault();
        }
        public void Save()
        {
            _tramContext.SaveChanges();
        }
    }
}
