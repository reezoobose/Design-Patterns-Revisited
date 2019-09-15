using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    [CreateAssetMenu(fileName = "New Game Event",menuName = "Game Event",order = 51)]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventListener> _listOfListeners = new List<GameEventListener>();

        public void Register(GameEventListener eventListener)
        {
            _listOfListeners.Add(eventListener);
        }

        public void UnRegister(GameEventListener eventListener)
        {
            _listOfListeners.Remove(eventListener);
        }

        public void OnOccured()
        {
            foreach (var item in _listOfListeners)
            {
                Debug.Log("On occured called on "+item.name);
                item.FireEvent();
            }
        }
    }
}
