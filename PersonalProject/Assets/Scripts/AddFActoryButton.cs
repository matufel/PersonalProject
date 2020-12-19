using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFActoryButton : MonoBehaviour
{
    bool ButtonsOut;
    // Start is called before the first frame update
    void Start()
    {
        ButtonsOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void OnButton()
    {
        GameObject Store = GameObject.Find("BuildStore");
        GameObject Proccesing = GameObject.Find("BuildProccesing");
        GameObject Production = GameObject.Find("BuildProduction");
        if (ButtonsOut == false)
        {
            Store.transform.Translate(0f, 60f, 0f);
            Proccesing.transform.Translate(0f, 120f, 0f);
            Production.transform.Translate(0f, 180f, 0f);
            ButtonsOut = true;
        }
        else
        {
            Store.transform.Translate(0f, -60f, 0f);
            Proccesing.transform.Translate(0f, -120f, 0f);
            Production.transform.Translate(0f, -180f, 0f);
            ButtonsOut = false;
        }
        
        
        print("ButtonWasPressed");
    }
}
