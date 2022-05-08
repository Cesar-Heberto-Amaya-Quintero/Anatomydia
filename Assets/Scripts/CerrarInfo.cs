using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarInfo : MonoBehaviour
{   
    public static bool cerrar = false;
    public GameObject info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cerrar()
    {
        cerrar = true;
        Debug.Log(cerrar);
        Destroy(info);
        OrganoActivo.info = false;
    }
}
