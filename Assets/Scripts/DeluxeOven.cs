using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class DeluxeOven : Oven
{
    private void Awake()
    {
        OvenName = "Deluxe Oven";
        OvenPower = 1.0f;

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
