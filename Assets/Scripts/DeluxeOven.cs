using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

//INHERITENCE
public class DeluxeOven : Oven
{
    public float ovenPower;
    private void Awake()
    {
        OvenName = "Deluxe Oven";
        OvenPower = 1.0f;
        CurrentProduction = "Nothing";

     

        BakeOptions.Add("Nothing");
        BakeOptions.Add("Bread");
        BakeOptions.Add("Pretzel");
        //BakeOptions.Add("Bagel");

    }
    // Update is called once per frame
    void Update()
    {
        DoBake();
    }
}
