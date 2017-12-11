using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class DecoratorSauna : CalculatorDecoration
    {
            public DecoratorSauna(Calculator calculator) : base(calculator) { }


            public override int calculateCost()
            {
                return base.calculateCost() + 300;
            }

            public override string getName()
            {
                return base.getName() + " + sauna";
            }
        }
    }

