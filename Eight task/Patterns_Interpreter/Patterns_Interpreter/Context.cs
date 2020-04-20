using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Interpreter
{
    class Context
    {
        public string dataToConvert { get; set; }
        public string basicNumberSystem { get; set; }
        public string newNumberSystem { get; set; }
        public string Output { get; set; }

        public Context(string input)
        {
            string[] data = input.Split(", из ");
            string[] numberSystems = data[1].Split(" в ");
            dataToConvert = data[0];
            basicNumberSystem = numberSystems[0];
            newNumberSystem = numberSystems[1];
        }
    }
}
