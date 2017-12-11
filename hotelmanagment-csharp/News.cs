using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class News : Observed
    {
        private List<Observer> list = new List<Observer>();
        string title;
        string description;
        public void addObserved(Observer observer)
        {
            list.Add(observer);
        }
        public void deleteObserved(Observer observer)
        {
            list.Remove(observer);
        }
        public void notifyObservers()
        {
            foreach (var item in list)
            {
                item.update();
            }
        }

        public string getTitle()
        {
            return title;
        }

        public string getDescription()
        {
            return description;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
