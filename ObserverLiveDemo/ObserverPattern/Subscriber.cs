using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverLiveDemo.ObserverPattern.Interfaces;
using Console = System.Console;

namespace ObserverLiveDemo.ObserverPattern
{
    public class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void Update(string title)
        {
            Console.WriteLine($"There is a new blog for you {_name}! '{title}'");
        }
    }
}
