using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern
{
    public class Counter : ISubject
    {
        private List<IObserver> observers;
        private int count;

        public Counter()
        {
            observers = new List<IObserver>();
            count = 0;
        }

        public void Increament()
        {
            count++;
            NotifyObservers(count);
        }

        public void Decrement()
        {
            if (count > 0)
            {
                count--;    
            }
            
            NotifyObservers(count);
        }
        public void RegisterObserver(Observer.IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegisterObserver(Observer.IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int count)
        {
            foreach (var observer in observers)
            {
                observer.Update(count);
            }
        }
    }
}
