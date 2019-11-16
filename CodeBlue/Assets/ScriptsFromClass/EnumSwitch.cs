using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
    public class EnumSwitch : MonoBehaviour
    {
        public enum States
        {
            Start,
            Playing,
            End
        }

        public UnityEvent OnStartEvent, OnPlayingEvent, OnEndEvent;


        public States currentState;

        void Update()
        {
            switch (currentState)
            {
                case States.Start:
                    OnStartEvent.Invoke();
                    break;
                case States.Playing:
                    OnPlayingEvent.Invoke();
                    break;
                case States.End:
                    OnEndEvent.Invoke();
                    break;
            }
        }
    }
}
