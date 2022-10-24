using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLiveDemo.ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void Subscribe(IObserver sub);

        void Unsubscribe(IObserver sub);

        void Upload(string title);

        void NotifySubs(string title);
    }
}
