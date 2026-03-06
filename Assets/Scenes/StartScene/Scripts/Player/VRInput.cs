using UnityEngine;
using UnityEngine.InputSystem;

public class VRInput : MonoBehaviour, IPlayerInput
{
    [Header("Settings")]
    [SerializeField] private Transform _controllerTransform; // assign the right hand controller
    [SerializeField] private InputActionReference triggerAction;

    void Start()
    {
        triggerAction.action.Enable();
    }
    void OnEnable()
    {
        triggerAction.action.Enable();
    }

    void OnDisable()
    {
        triggerAction.action.Disable();
    }

    public Vector3 GetAimDirection()
    {
        return _controllerTransform.forward;
    }

    public Vector3 GetAimOrigin()
    {
        return _controllerTransform.position;
    }

    public bool getShootTrigger()
    {
        float value = triggerAction.action.ReadValue<float>();
        Debug.Log($"Trigger float value: {value}");
        return value > 0.1f;
    }
}