using UnityEngine;

public class HealthPowerupCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>())
        {
            // Raises the player's health by 1
            collision.GetComponent<PlayerHealth>().RaiseHealth();
            
            Destroy(gameObject);
        }
    }
}
