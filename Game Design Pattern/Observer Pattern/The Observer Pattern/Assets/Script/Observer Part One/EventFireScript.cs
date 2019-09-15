using UnityEngine;

namespace Script
{
    public class EventFireScript : MonoBehaviour
    {

        public GameEvent gameEvent ;

        private void Start()
        {
            gameEvent.OnOccured();
        }
    }
}
