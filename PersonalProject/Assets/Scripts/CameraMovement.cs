using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 poz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Makes poz equal to the objects position
        poz = transform.position;
        // Movement 
        float CameraSpeed = 0.2f;
        transform.Translate(CameraSpeed * Input.GetAxis("Horizontal"), 0f, 0f);
        transform.Translate(0f, 0f, CameraSpeed * Input.GetAxis("Vertical"));
        transform.Translate(0f, 1f * Input.mouseScrollDelta.y, 0f);

    }

}
