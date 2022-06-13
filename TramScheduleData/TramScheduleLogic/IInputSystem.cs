using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleLogic
{
    public interface IInputSystem
    {
        public string FetchStringValue(string prompt);
    }
}
