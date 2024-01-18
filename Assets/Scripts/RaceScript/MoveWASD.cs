using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using UnityEngine.UI;


public class MoveWASD : MonoBehaviour
{
    public float speed;

    float movementX;
    float movementY;

    Rigidbody2D rb;
    Transform car2;
    //public WinnerManager winnerManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementX = 0;
        movementY = 0;
        car2 = GameObject.FindWithTag("Car2").transform;
    }

    void Update()
    {
        rb.velocity = new Vector3(movementX * speed * Time.deltaTime, movementY * speed * 5 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            movementY = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movementY = -1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movementX = -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movementX = 1;
        }
        
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            movementY = 0;
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            movementX = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("engel"))
        {
            car2.transform.position = new Vector3(car2.transform.position.x, car2.transform.position.y - 0.5f, 0);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Flag"))
        {
            car2.transform.position = new Vector3(car2.transform.position.x, car2.transform.position.y + 0.5f, 0);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("finish"))
        {
            WinnerManager.WinnerNumber = 2;
            SceneManager.LoadScene(7);
        }
    }
}
