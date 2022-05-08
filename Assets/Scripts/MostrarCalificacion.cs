using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarCalificacion : MonoBehaviour
{
    public Text calificacion;
    // Start is called before the first frame update
    void Start()
    {
        calificacion.text = RespuestaCorrecta.respuestasCorrectas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
