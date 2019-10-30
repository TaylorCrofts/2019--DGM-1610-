using UnityEngine;
[CreateAssetMenu]
public class DebuggingScript : ScriptableObject
{
    public void OnDebug(string words)
    {
        Debug.Log(words);
    }

    public void OnDebug()
    {
        Debug.Log(name);
    }
}
