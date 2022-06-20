using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleData.GenericRepository.Interface
{
    public interface IGenericRepository<T> where T: class
    {
        void Insert(T obj);
        List<T> GetAll();
        void Save();
    }
}
