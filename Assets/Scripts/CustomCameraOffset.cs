using Unity.Cinemachine;
using UnityEngine;

public class CustomCameraOffset : MonoBehaviour
{
    public CinemachineCamera cinemachineCamera;
    public CinemachinePositionComposer positionComposer;

    void Start()
    {
        positionComposer = cinemachineCamera.GetComponent<CinemachinePositionComposer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }
}
