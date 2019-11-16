using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
    public class MouseEvents : MonoBehaviour
    {
        public UnityEvent MouseEvent;
        public void OnMouseUp()
        {
            MouseEvent.Invoke();
        }
    }
}

