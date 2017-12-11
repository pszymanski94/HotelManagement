using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class CalculatorDecoration : Calculator
    {
        protected Calculator _calculator;

        public CalculatorDecoration(Calculator calculator)
        {

            this._calculator = calculator;
        }
        public override int calculateCost()
        {
            return _calculator.calculateCost();
        }

        public override string getName()
        {
            return _calculator.getName();
        }
    }
}

