using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class StrategyPrepayment:Strategy
    {
        public float CalculatorStrategy (int _price, int _numberofdays)
        {
            return (_price * _numberofdays) - 0.1f * (_price * _numberofdays);
        }
    }
}
