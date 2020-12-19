using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProccesingScript : MonoBehaviour
{
    bool placed;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-62.1f, 10f, -14f);
        placed = false;
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = !m_Collider.enabled;
    }

    private RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (placed == true)
        {

        }
        else
        {
            Placing();
        }
    }
    void Placing()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y + 0.25f, hit.point.z);
        }
        if (Input.GetMouseButtonDown(0))
        {
            placed = true;
            m_Collider.enabled = !m_Collider.enabled;
        }
    }
}
