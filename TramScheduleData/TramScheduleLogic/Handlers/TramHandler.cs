using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramScheduleData.Model;
using TramScheduleData.UngenericRepository;

namespace TramScheduleLogic
{
    public class TramHandler
    {
        private TramRepository _tramRepository;
        private IInputSystem _inputSystem;

        public TramHandler()
        {
            _tramRepository = new TramRepository();
            _inputSystem = new ConsoleInputSystem();
        }

        public Tram Add()
        {
            string name = _inputSystem.FetchStringValue("Name of the tram");
            var tram = new Tram(name);
            _tramRepository.Insert(tram);
            _tramRepository.Save();
            return tram;
        }

        public void AddRoute(Tram tram, Route route)
        {
            tram.Route = route;
            _tramRepository.Save();
        }
    }
}
