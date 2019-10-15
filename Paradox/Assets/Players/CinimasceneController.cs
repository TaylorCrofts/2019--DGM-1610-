
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinimasceneController : MonoBehaviour
{
	public PlayerData playerdata;
private CinemachineVirtualCamera virtualCamera;
	void Start ()
	{
		virtualCamera = GetComponent<CinemachineVirtualCamera>();
		playerdata.instanceAction = instanceHandler;
			playerdata.InstancePlayer();
	}

	private void instanceHandler(GameObject obj)
	{
		virtualCamera.Follow = obj.transform;
	}
}
