using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class DecoratorSaltCave:CalculatorDecoration
    { public DecoratorSaltCave(Calculator calculator) : base(calculator) { }


        public override int calculateCost()
        {
            return base.calculateCost() + 800;
        }

        public override string getName(){
            return base.getName() + " + grota";
        }
    
    }
}
