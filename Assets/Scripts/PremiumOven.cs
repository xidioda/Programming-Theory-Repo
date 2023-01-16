using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITENCE
public class PremiumOven : Oven
{
    public float ovenPower;

    public bool ecoMode = false;

    private void Awake()
    {
        OvenName = "Premium Oven";
        OvenPower = 1.5f;
        CurrentProduction = "Nothing";   

        BakeOptions.Add("Nothing");
        BakeOptions.Add("Bread");
        BakeOptions.Add("Pretzel");
        BakeOptions.Add("Bagel");
    }

    //POLYMORPHISM
    protected override void DoBake()
    {
        base.DoBake();
        if (ecoMode) //this mode is available only on Premium Ovens
        {
            //Reduced Electricity Consumption
        }
    }

    // Update is called once per frame
    void Update()
    {
        DoBake();
    }
}
