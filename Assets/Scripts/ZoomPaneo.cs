using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPaneo : MonoBehaviour
{
    Vector3 touchStar;
    public float zoomOutMin = 150;
    public float zoomOutMax = 10;
    [SerializeField]
    float velocidadZoom = 0.5f;
    [SerializeField]
    Vector2 Limites;
    // public Camera cam;
    public float groundZ = 0;
    bool paneo = true;
    // private bool multiTouch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0)) {
        //     // multiTouch = false;
        //     touchStar = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // }
        // if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        // {
        // Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
        // RaycastHit hit;

        // if (Physics.Raycast(ray, out hit))
        //     {
        //         if (hit.transform.tag == "Modelo"|| hit.transform.tag == "Organo" )
        //         {
        //             Debug.Log("ESTO ES UN MODELO");
        //         }
        //     }
        // }
        if(Input.touchCount == 0 ) {
                
                paneo = true;
        }
        
        if(Input.touchCount == 1 ){

            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "Modelo"|| hit.transform.tag == "Organo" )
                    {
                        Debug.Log("ESTO ES UN MODELO");
                        paneo = false;
                    }
                    
                    
                }
            
            
            if(paneo){
                if(Input.GetMouseButtonDown(0)) {
                    touchStar = GetWorldPosition(groundZ);
                }
                if(Input.GetMouseButton(0)) {
                    Vector3 direction = touchStar - GetWorldPosition(groundZ);
                    Camera.main.transform.position += direction;
                }
            }
        }

        if(Input.touchCount == 2) {
            // multiTouch = true;
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            // Zoom(difference * 0.0001f);

            Camera.main.fieldOfView -= difference * velocidadZoom;
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, Limites.x, Limites.y);
        } // else if(Input.GetMouseButton(0)) {
        //     Vector3 direction = touchStar - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     Camera.main.transform.position += direction;
        // }
        // Zoom(Input.GetAxis("Mouse ScrollWheel"));
    }

    private Vector3 GetWorldPosition(float z){
        Ray mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.forward, new Vector3(0,0,z));
        float distance;
        ground.Raycast(mousePos, out distance);
        return mousePos.GetPoint(distance);
    }

    // void Zoom(float increment) {
    //     Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView - increment, zoomOutMin, zoomOutMax);

    // }
}
