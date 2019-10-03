using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
//you'll always get the same data type everytime. (Text) is the data type in this example.

[RequireComponent(typeof(Text))]
public class UITextControler : MonoBehaviour
{
	public UnityEvent startEvent;
	private Text textLable;

	public void UpdateText(IntData data)
	{
		textLable.text = data.value.ToString();
	}
	private void Start()
	{
		textLable = GetComponent<Text>();
		startEvent.Invoke();
	}
}