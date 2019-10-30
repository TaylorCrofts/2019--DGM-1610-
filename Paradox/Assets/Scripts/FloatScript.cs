using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 5f;
    public float minValue = 0f;
    public float maxValue = 10f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void UpdateValueRange(float amount)
    {
        if (value>=minValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = minValue;
        }
        

        if (value<=maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
    }
}
