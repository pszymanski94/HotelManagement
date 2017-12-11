using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    interface Strategy
    {
        float CalculatorStrategy(int _price, int _numberofdays);
    }
}
