using UnityEngine;

[CreateAssetMenu]
public class FloatScript : ScriptableObject
{
    public float value = 2f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }
}
