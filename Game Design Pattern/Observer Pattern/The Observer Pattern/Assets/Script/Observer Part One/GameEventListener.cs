using UnityEngine;
using UnityEngine.Events;

namespace Script
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        public UnityEvent responseOfGameEvent;


        private void OnEnable()
        {
            gameEvent.Register(this);
        }

        private void OnDisable()
        {
            gameEvent.UnRegister(this);
        }

        public void FireEvent()
        {
            responseOfGameEvent.Invoke();
        }

    }
}
