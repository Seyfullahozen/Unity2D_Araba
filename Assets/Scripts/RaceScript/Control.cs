using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    Rigidbody2D rb;
    private Transform arabaTransform;
    Transform car1;
    Transform car2;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        car1 = GameObject.FindWithTag("Car1").transform;
        car2 = GameObject.FindWithTag("Car2").transform;

    }

    void FixedUpdate()
    {
        if (transform.position.x > 1.7f)
        {
            Vector3 right_limit = new Vector3(1.7f, transform.position.y);
            transform.position = right_limit;
        }

        if (transform.position.x < -1.65f)
        {
            Vector3 left_limit = new Vector3(-1.65f, transform.position.y);
            transform.position = left_limit;
        }

        if (car1.transform.position.y < -3.6f)
        {
            car1.transform.position = new Vector3(car1.transform.position.x, -3.1f, 0);
            car2.transform.position = new Vector3(car2.transform.position.x, car2.transform.position.y + 0.5f, 0);
        }

        if (car2.transform.position.y < -3.6f)
        {
            car2.transform.position = new Vector3(car2.transform.position.x, -3.1f, 0);
            car1.transform.position = new Vector3(car1.transform.position.x, car1.transform.position.y + 0.5f, 0);
        }

        if (car1.transform.position.y > 2f)
        {
            car1.transform.position = new Vector3(car1.transform.position.x, 1.5f, 0);
            car2.transform.position = new Vector3(car2.transform.position.x, car2.transform.position.y - 0.5f, 0);
        }

        if (car2.transform.position.y > 2f)
        {
            car2.transform.position = new Vector3(car2.transform.position.x, 1.5f, 0);
            car1.transform.position = new Vector3(car1.transform.position.x, car1.transform.position.y - 0.5f, 0);
        }

        float mesafe = Mathf.Abs(car1.position.y - car2.position.y);
        if (mesafe >= 5.3f)
        {
            SceneManager.LoadScene(7);
        }
    }
}
