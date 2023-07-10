using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public bool isforpoints;

    private void Start()
    {
        //isforpoints = true;
    }

public void toggler()
    {
        if (isforpoints)
        { 
            isforpoints = false; 
            Debug.Log("FOREVER");
            return;
        } 
        else 
        { 
            isforpoints = true;
            Debug.Log("POINTS");
            return;
        }
        
        

        
    }

}
