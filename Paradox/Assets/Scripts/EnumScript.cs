using UnityEngine;
using UnityEngine.Events;

public class EnumScript : MonoBehaviour 
{
    public enum States
    {
        Start,
        Playing,
        End
    }

    public States currentState;
    public UnityEvent onStartEvent, onPlayingEvent, onEndEvent;

    void Update()
    {
        switch (currentState)
        {
            case States.Start:
                onStartEvent.Invoke();
                print("Starting");
                break;
            case States.Playing:
                onPlayingEvent.Invoke();
                print("Playing");
                break;
            case States.End:
                onEndEvent.Invoke();
                print("Ending");
                break;
            default:
                onStartEvent.Invoke();
                print("Default Start");
                break;
        }
    }
}
