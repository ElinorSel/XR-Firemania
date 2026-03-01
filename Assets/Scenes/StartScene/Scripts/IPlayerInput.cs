using UnityEngine;

public interface IPlayerInput
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    //Where are we aiming?
    Vector3 GetAimDirection(); 

    //Should we fire?
    bool getShootTrigger();

// Where should the water stream come from: //TODO: in the future this should be connected to the hose and not the camera
    public Vector3 GetAimOrigin();

}
