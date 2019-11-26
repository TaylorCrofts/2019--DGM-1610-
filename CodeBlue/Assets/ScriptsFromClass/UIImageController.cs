using UnityEngine.UI;
using UnityEngine;
[RequireComponent(typeof(Image))]
public class UIImageController : MonoBehaviour {

    private Image iMAGES;
    void Awake()
    {
        iMAGES = GetComponent<Image>();
    }

    public void UpdateImage(HealthFloatScript data)
    {
        iMAGES.fillAmount = data.value;
    }
}
