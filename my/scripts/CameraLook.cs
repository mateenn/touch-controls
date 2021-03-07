
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineFreeLook))]

public class CameraLook : MonoBehaviour
{
        [SerializeField]
    private float lookSpeed = 1;

    private CinemachineFreeLook Cinemachine;

    private Player playerInput;

    private void Awake()
    {
        playerInput = new Player();
        Cinemachine = GetComponent<CinemachineFreeLook>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable(); 
    }

    void Update()
    {
        Vector2 delta = playerInput.PlayerMain.Look.ReadValue<Vector2>();
        Cinemachine.m_XAxis.Value += delta.x * 200 * lookSpeed * Time.deltaTime;
        Cinemachine.m_YAxis.Value += delta.y * lookSpeed * Time.deltaTime;
    }
}
