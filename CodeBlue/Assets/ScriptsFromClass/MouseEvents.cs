
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent MouseEvent;
    public void OnMouseUp()
    {
        MouseEvent.Invoke();
    }
}

