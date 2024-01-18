using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveArrows : MonoBehaviour
{
    public float speed;

    float movementX;
    float movementY;

    Rigidbody2D rb;
    Transform car1;
    //public WinnerManager winnerManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementX = 0; 
        movementY = 0;
        car1 = GameObject.FindWithTag("Car1").transform;
    }

    void Update()
    {
        rb.velocity = new Vector3(movementX * speed * Time.deltaTime, movementY * speed * 5 * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementY = 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movementY = -1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movementX = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movementX = 1;
        }
        
        if(Input.GetKeyUp(KeyCode.UpArrow) ||  Input.GetKeyUp(KeyCode.DownArrow)) 
        { 
            movementY = 0; 
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            movementX = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("engel"))
        {
            car1.transform.position = new Vector3(car1.transform.position.x, car1.transform.position.y - 0.5f, 0);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Flag"))
        {
            car1.transform.position = new Vector3(car1.transform.position.x, car1.transform.position.y + 0.5f, 0);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("finish"))
        {
            WinnerManager.WinnerNumber = 1;
            SceneManager.LoadScene(7);
        }
    }
}
