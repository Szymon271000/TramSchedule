﻿using System;
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
        public List<Stop> GetAll()
        {
            return _tramContext.Stops.ToList();
        }

        public void Insert(Stop obj)
        {
            _tramContext.Stops.Add(obj);
        }

        public void Save()
        {
            _tramContext.SaveChanges();
        }
    }
}