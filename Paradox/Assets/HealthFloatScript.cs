using UnityEngine;

[CreateAssetMenu]
public class HealthFloatData : ScriptableObject
{
    public float value = 5f;

    public void UpdateHealthValue(float amount)
    {
        value += amount;
    }
}
