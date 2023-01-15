using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremiumOven : Oven
{

    private void Awake()
    {
        OvenName = "Premium Oven";
        OvenPower = 1.5f;

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
