using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextController : MonoBehaviour
{
    private Text textLabel;
    void Awake()
    {
        textLabel = GetComponent<Text>();
    }
    public void UpdateText(IntData data)
    {
        textLabel.text = data.value.ToString();
    }
}
