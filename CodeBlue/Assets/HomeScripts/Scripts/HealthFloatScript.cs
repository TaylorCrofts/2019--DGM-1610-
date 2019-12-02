using UnityEngine;

[CreateAssetMenu]
public class HealthFloatScript : ScriptableObject
{
    public float value = 5f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }
}
