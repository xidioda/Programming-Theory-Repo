using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITENCE
public class BasicOven : Oven
{
    public float ovenPower;
    
    private void Awake()
    {
        OvenName = "Basic Oven";
        OvenPower = 0.5f;
        CurrentProduction = "Nothing";

       

        BakeOptions.Add("Nothing");
        BakeOptions.Add("Bread");
        //BakeOptions.Add("Pretzel");
        //BakeOptions.Add("Bagel");
        
    }

    // Update is called once per frame
    void Update()
    {
       DoBake();
    }
}
