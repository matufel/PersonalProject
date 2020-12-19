using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3 CurrentPoz;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // accses the variable poz from the CameraMovment script
        GameObject CameraBlock = GameObject.Find("CameraBlock");
        CameraMovement CamBlockScript = CameraBlock.GetComponent<CameraMovement>();
        var CamBPoz = CamBlockScript.poz;
        // Makes poz the current pozition of the object
        transform.position = Vector3.MoveTowards(transform.position, CamBPoz, 0.2f);
    }
}
