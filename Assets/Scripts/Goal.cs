using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision with goal at position " + collision.gameObject.transform.position + " with velocity " + collision.gameObject.GetComponent<Rigidbody2D>().velocity + " at time " + Time.time);
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("collsiion with goal");
            if (!isPlayer1Goal)
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            else
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}
