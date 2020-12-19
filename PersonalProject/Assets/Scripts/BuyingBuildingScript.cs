using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingBuildingScript : MonoBehaviour
{
    public Transform StorePre;
    public Transform ProccesingPre;
    public Transform ProductionPre;

    public int StoreNr;
    public int ProdNr;
    public int ProcNr;
    // Start is called before the first frame update
    void Start()
    {
        StoreNr = 0;
        ProdNr = 0;
        ProcNr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void Store()
    {
        print("store");
        var StoreClone = Instantiate(StorePre);
        print(StoreNr);
        StoreClone.name = "Store" + StoreNr;
        StoreNr = StoreNr + 1;
    }

    public void Prduction()
    {
        ProdNr = ProdNr + 1;
        print("Production");
        Instantiate(ProductionPre, new Vector3(0, 0, 0), Quaternion.identity);
    }
    
    public void Proccesing()
    {
        ProcNr = ProcNr + 1;
        print("Proccesing");
        Instantiate(ProccesingPre, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
