using UnityEngine;

namespace Script.Observer_Part_two
{
    public class ObserverPartTwo : Observer
    {
        public override void OnNotify()
        {
            Debug.Log("Notification Received.");
            Debug.Log("Say hello from the class Observer Part Two.");
        }
    }
}
