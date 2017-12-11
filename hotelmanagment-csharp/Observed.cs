using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    interface Observed
    {
        
         void addObserved(Observer obser);
         void deleteObserved(Observer obser);
         void notifyObservers();
    }
}
