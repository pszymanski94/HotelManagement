using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class DecoratorMassage : CalculatorDecoration
    {
        public DecoratorMassage(Calculator calculator) : base(calculator) { }


        public override int calculateCost()
        {
            return base.calculateCost() + 450;
        }

        public override string getName(){
            return base.getName() + " + masaż";
        }
    }
}




