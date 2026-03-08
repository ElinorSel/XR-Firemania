using UnityEngine;

public class PlayerFireDetector : MonoBehaviour
{
        [SerializeField] private GameObject DeathUI;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            Debug.Log("DETCECTION BURN!");
        }
    }
}