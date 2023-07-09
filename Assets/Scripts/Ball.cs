using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isPlayer1;
    public float speed;
    public Vector3 startPosition;


    private void Start()
    {
        startPosition = transform.position;
        
    }


    
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

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}

