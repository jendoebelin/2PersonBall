using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SplashCountdown : MonoBehaviour
{
    public int CountdownTime;
    public UnityEvent OnCountdownFinished;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (CountdownTime > 0)
        {
            

            yield return new WaitForSeconds(1f);

            CountdownTime--;

        }

       


        LoadStartMenu();

        yield return new WaitForSeconds(1f);

        


    }
}
