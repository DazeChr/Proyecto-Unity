using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    void OnCollisionEnter2D(Collision collision)
    {
        if (collision.collider.tag == "Player")
            Destroy(collision.collider.gameObject);
         Destroy(gameObject);
    }
}
    
