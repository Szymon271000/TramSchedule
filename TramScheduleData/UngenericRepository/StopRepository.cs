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
    public class StopRepository : IGenericRepository<Stop>
    {
        private readonly TramContext _tramContext;

        public StopRepository()
        {
            _tramContext = new TramContext();
        }

        public StopRepository(TramContext tramContext)
        {
            _tramContext = tramContext;
        }

        public List<Stop> GetAll()
        {
            return _tramContext.Stops.ToList();
        }

        public void Insert(Stop obj)
        {
            _tramContext.Stops.Add(obj);
        }

        public Stop GetStop(int id)
        {
            return _tramContext.Stops.AsNoTracking().Where(x => x.StopId == id).SingleOrDefault();
        }

        public Stop GetStopByName(string name)
        {
            return _tramContext.Stops.AsNoTracking().Where(x => x.Name == name).SingleOrDefault();
        }
        public void Save()
        {
            _tramContext.SaveChanges();
        }
    }
}
