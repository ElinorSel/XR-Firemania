using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private ParticleSystem waterStream;
    private IPlayerInput _input;

    // In Awake, we look for any script on this object (whichever object has the PlayerController component added to it) that implements IPlayerInput. 
    // The code below finds either KeyboardInput OR VRInput depending on which one is enabled in the Inspector.
    void Awake()
   {
       _input = GetComponent<IPlayerInput>(); 
   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootWaterStream();
    }

    void ShootWaterStream()
    {
        if (_input.getShootTrigger())
        {
          waterStream.Play();
          var emission = waterStream.emission;
          emission.enabled = true;
        }
        else
        {
            var emission = waterStream.emission;
            emission.enabled = false;
        }
    }
}
