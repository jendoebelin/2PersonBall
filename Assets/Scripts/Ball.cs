using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isPlayer1;
    public float speed;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }
    //public void reset function
    //added Invoke to call the launch function after 0.5 second delay, hopefully fixing the accidental double OnTrigger due to the ball beig inside the goal collider when it gets its new velocity from launch
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Invoke("Launch", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}

