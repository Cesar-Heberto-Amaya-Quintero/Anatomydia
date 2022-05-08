using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganoActivo : MonoBehaviour
{
    public GameObject infoCerebro;
    public GameObject infoBazo;
    public GameObject infoPancreas;
    public GameObject infoHigado;
    public GameObject infoPulmon;
    public GameObject infoEstomago;
    public GameObject infoIntestinos;
    public GameObject infoPene;
    public GameObject infoUtero;
    public GameObject infoVejiga;
    public GameObject infoRinon;
    public GameObject infoCorazon;

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

                if (hit.transform.tag == "Bazo" && info ==false )
                {
                    Debug.Log("SELECCIONASTE BAZO");
                    
                    Instantiate(infoBazo, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Pancreas" && info ==false )
                {
                    Debug.Log("SELECCIONASTE PANCREAS");
                    
                    Instantiate(infoPancreas, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Higado" && info ==false )
                {
                    Debug.Log("SELECCIONASTE HIGADO");
                    
                    Instantiate(infoHigado, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Pulmon" && info ==false )
                {
                    Debug.Log("SELECCIONASTE PULMON");
                    
                    Instantiate(infoPulmon, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Estomago" && info ==false )
                {
                    Debug.Log("SELECCIONASTE ESTOMAGO");
                    
                    Instantiate(infoEstomago, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Intestinos" && info ==false )
                {
                    Debug.Log("SELECCIONASTE INTESTINOS");
                    
                    Instantiate(infoIntestinos, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Pene" && info ==false )
                {
                    Debug.Log("SELECCIONASTE PENE");
                    
                    Instantiate(infoPene, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Utero" && info ==false )
                {
                    Debug.Log("SELECCIONASTE UTERO");
                    
                    Instantiate(infoUtero, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Vejiga" && info ==false )
                {
                    Debug.Log("SELECCIONASTE VEJIGA");
                    
                    Instantiate(infoVejiga, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Rinon" && info ==false )
                {
                    Debug.Log("SELECCIONASTE RIÑON");
                    
                    Instantiate(infoRinon, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }

                if (hit.transform.tag == "Corazon" && info ==false )
                {
                    Debug.Log("SELECCIONASTE CORAZON");
                    
                    Instantiate(infoCorazon, new Vector3(0,0,0), Quaternion.identity);
                    info = true;
                    Debug.Log(info);
                }
            }
        }
    }
}
