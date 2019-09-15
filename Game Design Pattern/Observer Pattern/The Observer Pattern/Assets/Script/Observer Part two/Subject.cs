using System.Collections.Generic;
using UnityEngine;

namespace Script.Observer_Part_two
{
    public class Subject
    {
        /// <summary>
        /// List of observer .
        /// </summary>
        private readonly List<Observer> _observers;
        public  Subject()
        {
            _observers = new List<Observer>();
        }

        /// <summary>
        /// Add observer .
        /// </summary>
        /// <param name="observerClass"></param>
        public void AddObserver(Observer observerClass)
        {
            _observers.Add(observerClass);
        }

        /// <summary>
        /// Remove observer .
        /// </summary>
        /// <param name="observerClass"></param>
        public void RemoveObserver(Observer observerClass)
        {
            _observers.Remove(observerClass);
        }

        /// <summary>
        /// Notify .
        /// </summary>
        public void Notify()
        {
            foreach (var item in _observers)
            {
                item.OnNotify();
            }
        }


    }
}
