using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverLiveDemo.ObserverPattern.Interfaces;

namespace ObserverLiveDemo.ObserverPattern
{
    public class Blog : ISubject
    {
        private ICollection<IObserver> Subscribers { get; } = new List<IObserver>();

        public void NotifySubs(string title)
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(title);
            }
        }

        public void Subscribe(IObserver sub)
        {
            Subscribers.Add(sub);
        }

        public void Unsubscribe(IObserver sub)
        {
            Subscribers.Remove(sub);
        }

        public void Upload(string title)
        {
            NotifySubs(title);
        }
    }
}
