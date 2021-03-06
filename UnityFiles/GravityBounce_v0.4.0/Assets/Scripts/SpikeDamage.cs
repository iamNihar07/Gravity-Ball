﻿using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
      // simplified health change on collision through the collider
      if (collision.gameObject.GetComponent<PlayerHealth>())
      {
        // Gets the PlayerHealth script from the player object if it was the object that 
        // collided with this one and lowers the player's health by 1
        collision.gameObject.GetComponent<PlayerHealth>().LowerHealth();
      }
    }
}
