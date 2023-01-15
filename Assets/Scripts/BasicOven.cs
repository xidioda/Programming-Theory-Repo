using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicOven : Oven
{
    
    private void Awake()
    {
        OvenName = "Basic Oven";
        OvenPower = 0.5f;

        BakeOptions.Add("Nothing");
        BakeOptions.Add("Bread");
        BakeOptions.Add("Pretzel");
        BakeOptions.Add("Bagel");
    }
    // Update is called once per frame
    void Update()
    {
       DoBake();
    }
}
