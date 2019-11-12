using UnityEngine;
//Assets can be used by everything
//ints are whole numbers
//ints store data
[CreateAssetMenu]
public class IntData : ScriptableObject
{
	public int value = 1;

	public void UpdateValue(int number)
	{
		value += number;
	}
	
}
