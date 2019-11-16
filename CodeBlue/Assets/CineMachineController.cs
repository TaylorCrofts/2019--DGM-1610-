using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CineMachineController : MonoBehaviour
{
    public PlayerData playerData;
    private CinemachineVirtualCamera virtualCamera;
    void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        playerData.instanceAction = InstanceHandler;
        playerData.InstancePlayer();
    }

    private void InstanceHandler(GameObject obj)
    {
        virtualCamera.Follow = obj.transform;
    }
}
