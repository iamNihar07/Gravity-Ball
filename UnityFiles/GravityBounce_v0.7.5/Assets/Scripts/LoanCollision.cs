using UnityEngine;

public class LoanCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // simplified health change on collision through the collider
        if (collision.gameObject.GetComponent<PlayerHealth>() && collision.gameObject.GetComponent<PlayerCoins>())
        {
            collision.gameObject.GetComponent<PlayerHealth>().LowerHealth();
            collision.gameObject.GetComponent<PlayerCoins>().RaiseCoin();
        }
    }
}
