using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoOrganos : MonoBehaviour
{
    public GameObject infoOrgano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InfoCerebro();
    }

    void InfoCerebro() {
        Instantiate(infoOrgano, new Vector3(0,0,0), Quaternion.identity);
        
    }
}
