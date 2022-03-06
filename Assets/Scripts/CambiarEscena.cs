using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void LoadScene()
    {
        Debug.Log("QUEPASAAAA");
    }
    
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch);
            SceneManager.LoadScene("SampleScene");
            
        }
    }
    
}
