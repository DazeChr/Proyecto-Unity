using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject explosionPrefab;
    Rigidbody2D rb;
    bool hasHit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 instantiatePoint = collision.GetContact(0).point;
        Instantiate(explosionPrefab, instantiatePoint, Quaternion.identity);
    

        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        if (collision.collider.tag == "Target")
        {
            Destroy(collision.collider.gameObject);

        }

        Destroy(gameObject);
    }
}