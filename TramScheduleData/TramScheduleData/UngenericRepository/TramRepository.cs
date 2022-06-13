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
    public class TramRepository : IGenericRepository<Tram>
    {
        private readonly TramContext _tramContext;

        public TramRepository()
        {
            _tramContext = new TramContext();
        }
        public List<Tram> GetAll()
        {
            return _tramContext.Trams.ToList();
        }

        public void Insert(Tram obj)
        {
            _tramContext.Trams.Add(obj);
        }

        public void Save()
        {
            _tramContext.SaveChanges();
        }
    }
}
