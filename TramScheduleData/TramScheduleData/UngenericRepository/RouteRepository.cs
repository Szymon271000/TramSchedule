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

        public void Save()
        {
            _tramContext.SaveChanges();
        }
    }
}
