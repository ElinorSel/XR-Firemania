using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour, IPlayerInput
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Settings")] 
    [SerializeField] private Transform _headCamera;
    [SerializeField] private float _mouseSensitivity = 2.0f;



    private float _rotationX;
    private float _rotationY;


    private bool _hasFired;           // Did we shoot this frame?
    InputAction shootAction;
    void Start()
    {
        // Hide and lock mouse cursor so it feels like an FPS game
        Cursor.lockState = CursorLockMode.Locked;
        shootAction = InputSystem.actions.FindAction("Shoot");
    }

    // Update is called once per frame
    void Update()
    {
            updateLookDirection();
            getShootTrigger();
    }

    private void updateLookDirection()
    {
                
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        _rotationY += mouseX;
        _rotationX -= mouseY;
        _rotationX = Mathf.Clamp(_rotationX, -90f, 90f); // Prevent looking too far up/down
        
        if (_headCamera)
            _headCamera.localRotation = Quaternion.Euler(_rotationX, _rotationY, 0);
    }
    public Vector3 GetAimDirection() //contract
    {
        return _headCamera.forward;
    }

    public Vector3 GetAimOrigin() //contract TODO: this should come from the hose later instead
    {
        return _headCamera.position;
    }

    public bool getShootTrigger(){ //contract
        Debug.Log(shootAction.IsPressed());
        return shootAction.IsPressed();
    }

}
