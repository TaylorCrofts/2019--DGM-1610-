using UnityEngine;
public partial class StringImpostarClass : MonoBehaviour
{
    public string intruderName;

    private void Start()
    {
        Debug.Log("Hello " + intruderName + " you are an Impostor");
    }
}
