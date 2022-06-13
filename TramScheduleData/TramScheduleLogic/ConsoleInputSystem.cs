using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleLogic
{
    public class ConsoleInputSystem : IInputSystem
    {
        public string FetchStringValue(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
