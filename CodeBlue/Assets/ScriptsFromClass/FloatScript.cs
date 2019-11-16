using UnityEngine;

namespace ScriptsFromClass
{
    [CreateAssetMenu]
    public class FloatScript : ScriptableObject
    {
        public float value = 2f;

        public void UpdateValue(float amount)
        {
            value += amount;
        }
    }
}
