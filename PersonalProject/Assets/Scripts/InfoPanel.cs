using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    bool PanelOut;
    // Start is called before the first frame update
    void Start()
    {
        PanelOut = false;
    }
    private RaycastHit hit;
    
    // Update is called once per frame
    void Update()
    {   
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                print(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name.Contains("Store") == true || hit.collider.gameObject.name.Contains("Production") == true || hit.collider.gameObject.name.Contains("Proccesing") == true)
                {
                    if (PanelOut == false)
                    {
                        if (hit.collider.gameObject.name.Contains("Store") == true)
                        {
                            transform.Translate(300f, 0f, 0f);
                            PanelOut = true;
                        }
                    }
                    else
                    {
                        CloseInfopanel();
                    }
                }
            }
        }
       
    }
    void CloseInfopanel()
    {
        PanelOut = false;
        transform.Translate(-300f, 0f, 0f);
    }
}
