using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

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

    public bool IsForPoints;
    public int MaxPoints = 3;

    public bool IsForTime = true;
    public float MaxTime = 3.0f;

    public int Player1Score = 0;
    public int Player2Score = 0;

    public AudioSource src;
    public AudioClip clip;

    public AudioClip victory;

    public GameObject PausePanel;
 

    public void Player1Scored()
    {


        //if (IsForPoints) { Debug.Log("gamemode is for points"); }
        if (!IsForPoints) { 
            Player1Score++;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
            src.clip = clip;
            src.Play();
            ResetPosition();
            return;
        }

        if (IsForPoints && Player1Score < MaxPoints)
        {
            Debug.Log("Player 1 Scored at time: " + Time.time);
            Player1Score++;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
            src.clip = clip;
            src.Play();
            ResetPosition();
        }
        else
        {
            Time.timeScale = 0;
            Debug.Log("Player 1 defeated Player 2");
            Player1Text.GetComponent<TextMeshProUGUI>().text = "VICTORY";
            src.clip = victory;
            src.Play();
            Player2Text.GetComponent<TextMeshProUGUI>().text = "LOSER";

            PausePanel.SetActive(true);


        }
    }

    public void Player2Scored()
    {
        

        if (!IsForPoints)
        {
            Player2Score++;
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
            src.clip = clip;
            src.Play();
            ResetPosition();
            return;
        }

        if (IsForPoints && Player2Score < MaxPoints)
        {
            Debug.Log("Player 2 Scored at time: " + Time.time);
            Player2Score++;
            src.clip = clip;
            src.Play();
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
            ResetPosition();
        }
        else
        {
            Time.timeScale = 0;
            Debug.Log("Player 2 defeated Player 1");
            Player1Text.GetComponent<TextMeshProUGUI>().text = "LOSER";
            Player2Text.GetComponent<TextMeshProUGUI>().text = "VICTORY";
            src.clip = victory;
            src.Play();
            PausePanel.SetActive(true);
        }


    }

    
    
    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        
    }
}