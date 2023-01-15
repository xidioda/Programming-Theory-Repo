using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private TextMeshProUGUI breadsText;

    [SerializeField]
    private GameObject ovenControlPanel;

    public static float Breads = 0;
    public static float Pretzels = 0;
    public static float Bagels = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);      
    }

    // Update is called once per frame
    void Update()
    {
        breadsText.SetText("Breads: " + Mathf.RoundToInt(Breads));
    }

    public void HideOvenControlPanel()
    {
        ovenControlPanel.SetActive(false);
    }
}
