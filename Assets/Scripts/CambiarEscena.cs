using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        OrganoActivo.info = false;
        Debug.Log(RespuestaCorrecta.respuestasCorrectas);
        SceneManager.LoadScene(sceneName);
    }

    public void SalirQuiz(string sceneName)
    {
        RespuestaCorrecta.respuestasCorrectas = 0;
        Debug.Log(RespuestaCorrecta.respuestasCorrectas);
        SceneManager.LoadScene(sceneName);
    }

    public void CerrarApp()
    {
        Application.Quit();
        Debug.Log("Saliste de la app");
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
