using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{
    public int CountdownTime;
    public Text countdownDisplay;
    public UnityEvent OnCountdownFinished;
    public Ball ball;
    public int check;
    public AudioSource src;
    public AudioClip bing, bong;
    public AudioSource bg;
    public AudioClip track;

    private void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(CountdownTime > 0)
        {
            src.clip = bing;
            src.Play();
            countdownDisplay.text = CountdownTime.ToString();

            yield return new WaitForSeconds(1f);

            CountdownTime--;
            
        }

        countdownDisplay.text = "Start";
        src.clip = bong;
        src.Play();

    
        ball.Launch();

        bg.clip = track;
        bg.Play();

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

        
    }
}
