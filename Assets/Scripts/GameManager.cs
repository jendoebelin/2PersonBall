using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;



    public int Player1Score = 0;
    public int Player2Score = 0;

    public AudioSource src;
    public AudioClip clip;

    public void Player1Scored()
    {
        Debug.Log("Player 1 Scored at time: " + Time.time);
        Player1Score++;
        src.clip = clip;
        src.Play();

        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Debug.Log("Player 2 Scored at time: " + Time.time);
        Player2Score++;
        src.clip = clip;
        src.Play();

        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        
    }
}