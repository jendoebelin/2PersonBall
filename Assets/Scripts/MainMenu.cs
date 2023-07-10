using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class MainMenu : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip;

    public sc ButtonScore;

    public int CountdownTime = 3;


    public void EndlessGame()
    {
       SceneManager.LoadScene("NeverEnding");
     
    }

    public void PointMatch()
    {
        SceneManager.LoadScene("WinnerScene");

    }
    
    public void QuitGame()
    {
        Time.timeScale = 1;
        src.Stop();
        src.clip = clip;
        src.Play();

        StartCoroutine(CountdownToStart());
        
    }
    IEnumerator CountdownToStart()
    {
        while (CountdownTime > 0)
        {


            yield return new WaitForSeconds(1f);
            Debug.Log(CountdownTime.ToString());
            CountdownTime--;

        }
        Application.Quit();
    }

}
