using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramScheduleLogic;

namespace TramScheduleTests
{
    internal class MockedInputSystem : IInputSystem
    {
        public string? Text { get; set; }
        public string FetchStringValue(string prompt)
        {
            return Text;
        }
    }
}
