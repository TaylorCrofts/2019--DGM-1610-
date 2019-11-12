using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class UIImageControler : MonoBehaviour
{
	private Image _image;
	void Awake()
	{
	_image = GetComponent <Image>();
	}
	
	public void UpdateImage (FloatData data)
	{
		_image.fillAmount = data.value;
	}
}
