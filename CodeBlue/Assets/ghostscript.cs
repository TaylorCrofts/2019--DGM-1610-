using UnityEditor.VersionControl;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
	public GameObject grimm;
	void Start()
	{
		grimm.name = "Reaper";
		print("Hello?");
	}
}
