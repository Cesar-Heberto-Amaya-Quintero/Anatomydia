using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganoActivo : MonoBehaviour
{
    public GameObject infoCerebro;
    public static bool info = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Organo")
                {
                    var objectScript = hit.collider.GetComponent<RotarOrgano>();
                    objectScript.isActive = !objectScript.isActive;
                }

                if (hit.transform.tag == "Cerebro" && info ==false )
                {
                    Debug.Log("SELECCIONASTE CEREBRO");
                    
                    Instantiate(infoCerebro, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }
            }
        }
    }
}
