using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFlag : MonoBehaviour
{
    private float default_speed;
    public Sprite flag;
    private float randomX;

    Rigidbody2D rb;
    SpriteRenderer spr;
    Transform car1;
    Transform car2;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        car1 = GameObject.FindWithTag("Car1").transform;
        car2 = GameObject.FindWithTag("Car2").transform;

        spr.sprite = flag;

        default_speed = Random.Range(0.5f, 1f);

        randomX = Random.Range(-0.8f, 0.8f);

        transform.position = new Vector3(randomX, transform.position.y + 8, 0);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, -default_speed, 0);
    }
}
