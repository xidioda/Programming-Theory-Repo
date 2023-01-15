using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Oven : MonoBehaviour
{
    [SerializeField]
    protected GameObject ovenControlPanel;

    [SerializeField]
    protected TextMeshProUGUI ovenType;

    [SerializeField]
    protected TextMeshProUGUI prodPower;

    [SerializeField]
    protected TMP_Dropdown bakeOptionsDropdown;

    protected string OvenName = "Unknown";

    protected float OvenPower = 0;
    protected List<string> BakeOptions = new List<string>();
    protected string CurrentProduction = "Nothing";

    protected void OnMouseDown()
    {
        if (!ovenControlPanel.activeSelf)
        {
            ovenControlPanel.SetActive(true);
        }
        ovenType.SetText(OvenName);
        prodPower.SetText("Production Power: " + OvenPower.ToString("F2"));
        bakeOptionsDropdown.ClearOptions();
        bakeOptionsDropdown.AddOptions(BakeOptions);
        bakeOptionsDropdown.value = bakeOptionsDropdown.options.Select(option => option.text).ToList().IndexOf(CurrentProduction);
        bakeOptionsDropdown.onValueChanged.AddListener(delegate { ChangeCurrentProduction(); });
        Debug.Log(CurrentProduction);       
    }

    void ChangeCurrentProduction() //Bake Dropdown value changed
    {
        CurrentProduction = bakeOptionsDropdown.options[bakeOptionsDropdown.value].text;
    }

    
    protected void DoBake() //check what's chosen to be baked
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

    protected virtual void BakeBread(float productionPower) //bake Bread
    {
        float producedAmount = productionPower * Time.deltaTime;
        GameManager.Breads += producedAmount;
    }

    protected virtual void BakePretzel(float productionPower) //bake Pretzel
    {
        float producedAmount = productionPower * Time.deltaTime;
        GameManager.Pretzels += producedAmount;
    }

    protected virtual void BakeBagel(float productionPower) //bake Bagel
    {
        float producedAmount = productionPower * Time.deltaTime;
        GameManager.Bagels += producedAmount;
    }

   
}
