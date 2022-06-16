using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramScheduleData.Model;
using TramScheduleData.UngenericRepository;

namespace TramScheduleLogic
{
    public class StopHandler
    {
        private StopRepository _stopRepository;
        private IInputSystem _inputSystem;

        public StopHandler()
        {
            _stopRepository = new StopRepository();
            _inputSystem = new ConsoleInputSystem();
        }

        public StopHandler(StopRepository stopRepository, IInputSystem inputSystem)
        {
            _stopRepository = stopRepository;
            _inputSystem = inputSystem;
        }

        public Stop Add()
        {
            string nameofStop = _inputSystem.FetchStringValue("Name of the stop: ");
            string detailsofStop = _inputSystem.FetchStringValue("Details of the stop: ");
            var stop = new Stop(nameofStop, detailsofStop);
            _stopRepository.Insert(stop);
            _stopRepository.Save();
            return stop;
        }
    }
}
