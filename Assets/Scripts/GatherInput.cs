using UnityEngine;
using UnityEngine.InputSystem;

public class GatherInput : MonoBehaviour
{
    [SerializeField] private float _valueX;
    private Controls controls;

    public float ValueX => _valueX;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Player.Move.performed += StartMove; // se asocio al estado performed
        controls.Player.Move.canceled += StopMove;
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Move.performed -= StartMove; // se asocio al estado performed
        controls.Player.Move.canceled -= StopMove;
        controls.Player.Disable();
    }

    private void StartMove(InputAction.CallbackContext context)
    {
        _valueX = context.ReadValue<float>();
    }

    private void StopMove(InputAction.CallbackContext context)
    {
        _valueX = 0;
    }
}