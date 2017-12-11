using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class CalculatorSport:Calculator
    {
        public override int calculateCost()
        {
            return 1900;
        }

        public override string getName()
        {
            return "Pakiet Sport";
        }
    }
}
