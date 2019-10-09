using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealing : MonoBehaviour
{

    GameObject temp;
    PlayerHealth health;

    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Player")
      {
        temp = GameObject.FindWithTag("Player");
        health = (PlayerHealth) temp.GetComponent(typeof(PlayerHealth));
        health.raiseHealth();
      }

    }
}
