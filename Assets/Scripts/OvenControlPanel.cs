using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OvenControlPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ovenTypeText;
    [SerializeField]
    private TextMeshProUGUI productionPowerText;
    [SerializeField]
    private TextMeshProUGUI currentBakeText;
    [SerializeField]
    private TMP_Dropdown bakeOptionsDropdown;
    [SerializeField]
    private Toggle ecoToggle;

    private GameObject myOven; 

    public void InitializeFields()
    {
        myOven = GameManager.ExistingOvens.Where(obj => obj.name == gameObject.name).FirstOrDefault();

        Debug.Log(transform.name);

        if (myOven)
        {
            Oven myOvenComponent = myOven.GetComponent<Oven>();
            ovenTypeText.SetText(myOven.name);
            productionPowerText.SetText("Production Power: " + myOvenComponent.OvenPower.ToString("F2"));
            currentBakeText.SetText("Currently Baking: " +myOvenComponent.currentlyBaking);

            bakeOptionsDropdown.ClearOptions();
            bakeOptionsDropdown.AddOptions(myOvenComponent.BakeOptions);
            bakeOptionsDropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(myOvenComponent); });

            if (myOven.name == "Premium Oven")
            {
                ecoToggle.gameObject.SetActive(true);
                ecoToggle.isOn = false;
                ecoToggle.onValueChanged.AddListener(delegate { ToggleValueChanged(myOven); });
            }
        }
    }

    private void ToggleValueChanged(GameObject myOven)
    {
        myOven.GetComponent<PremiumOven>().ecoMode = ecoToggle.isOn;
    }

    void DropdownValueChanged(Oven theOven)
    {
        theOven.currentlyBaking = bakeOptionsDropdown.options[bakeOptionsDropdown.value].text;
        currentBakeText.SetText("Currently Baking: " + theOven.currentlyBaking);
    }
}
