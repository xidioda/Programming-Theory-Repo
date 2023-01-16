using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]
    private TextMeshProUGUI breadsText;
    [SerializeField]
    private TextMeshProUGUI pretzelsText;
    [SerializeField]
    private TextMeshProUGUI bagelsText;
    
    //Products
    public static float Breads = 0;
    public static float Pretzels = 0;
    public static float Bagels = 0;

    //Ingredients
    public static float Wheat = 100;
    public static float Water = 100;
    public static float Salt = 100;

    public static GameObject[] ExistingOvens;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        ExistingOvens = GameObject.FindGameObjectsWithTag("Oven");
        PanelManager.Instance.InstantiateAllPanels();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        breadsText.SetText("Breads: " + Mathf.RoundToInt(Breads));
        pretzelsText.SetText("Pretzels: " + Mathf.RoundToInt(Pretzels));
        bagelsText.SetText("Bagels: " + Mathf.RoundToInt(Bagels));
    }
}
