using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespuestaCorrecta : MonoBehaviour
{
    public static int respuestasCorrectas = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LoadScene(string sceneName)
    {   
        respuestasCorrectas ++;
        Debug.Log(respuestasCorrectas);
        SceneManager.LoadScene(sceneName);
    }
    
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch);
            // SceneManager.LoadScene("SampleScene");
            
        }
    }
}
