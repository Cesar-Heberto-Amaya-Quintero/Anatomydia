using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoRotarOrgano : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
            {
                Touch screenTouch = Input.GetTouch(0);

                if(screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, screenTouch.deltaPosition.x, 0);
                    transform.Rotate(screenTouch.deltaPosition.y, 0f, 0);
                }

            }
    }
}
