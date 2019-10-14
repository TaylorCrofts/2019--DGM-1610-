using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
//you'll always get the same data type everytime. (Text) is the data type in this example.

[RequireComponent(typeof(Text))]
public class UITextControler : MonoBehaviour
{
	public UnityEvent startEvent;
	public Text textLable;
	void Awake()
	{ 
		textLable = GetComponent<Text>();
	}
	
	public void UpdateText(IntData data)
	{ 
		textLable.text = data.value.ToString();
	}
}