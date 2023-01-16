using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Oven : MonoBehaviour
{
    //ENCAPSULATION
    public string OvenName { get; protected set; }
    public float OvenPower { get; protected set; }

    public List<string> BakeOptions { get; protected set; } = new List<string>();
    protected string CurrentProduction = "Nothing";
    public string currentlyBaking {
        get { return CurrentProduction; } 
        set { CurrentProduction = value; }
    }

    protected void OnMouseDown()
    {
        PanelManager.Instance.OpenPanel(OvenName);                 
    }
  
    protected virtual void DoBake() //check what's chosen to be baked
    {
        if (CurrentProduction == "Bread")
        {
            BakeBread(OvenPower);
        }
        else if (CurrentProduction == "Pretzel")
        {
            BakePretzel(OvenPower);
        }
        else if (CurrentProduction == "Bagel")
        {
            BakeBagel(OvenPower);
        }
    }

    //ABSTRACTION
    private void BakeBread(float productionPower) //bake Bread
    {
        float producedAmount = productionPower * Time.deltaTime;
        GameManager.Breads += producedAmount;
    }

    private void BakePretzel(float productionPower) //bake Pretzel
    {
        float producedAmount = productionPower * Time.deltaTime;
        GameManager.Pretzels += producedAmount;
    }

    private void BakeBagel(float productionPower) //bake Bagel
    {
        float producedAmount = productionPower * Time.deltaTime;
        GameManager.Bagels += producedAmount;
    }

   
}
