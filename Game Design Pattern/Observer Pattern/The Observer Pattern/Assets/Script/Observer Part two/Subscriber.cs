using UnityEngine;

namespace Script.Observer_Part_two
{
    public class Subscriber : MonoBehaviour
    {
        private Subject _subject;

        private void Awake()
        {
            _subject = new Subject();
        }

        private void OnEnable()
        {
            _subject.AddObserver(new ObserverPartOne());
            _subject.AddObserver(new ObserverPartTwo());
        }


        private void OnDisable()
        {
            _subject.RemoveObserver(new ObserverPartOne());
            _subject.RemoveObserver(new ObserverPartTwo());
        }

        private void Start()
        {
            _subject.Notify();
        }
    }
}
