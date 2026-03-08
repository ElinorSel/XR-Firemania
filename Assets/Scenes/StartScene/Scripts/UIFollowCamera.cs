using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.LookAt(player);
    }
}