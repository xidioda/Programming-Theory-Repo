using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public static PanelManager Instance;

    [SerializeField]
    private GameObject ovenControlPanelPrefab;
    
    private List<GameObject> panelsPool = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);
    }

    public void OpenPanel(string ovenName)
    {
        CloseAllPanels();

        GameObject panelExists = panelsPool.Where(obj => obj.name == ovenName).FirstOrDefault();
       
        if (panelExists)
            {
                panelExists.SetActive(true);
            }
        else
            {
                GameObject panel = Instantiate(ovenControlPanelPrefab, GameObject.FindWithTag("Canvas").transform);
                panel.name = ovenName;
                panelsPool.Add(panel);
                panel.SetActive(true);
                panel.GetComponent<OvenControlPanel>().InitializeFields();
        }
        
    }

    private void CloseAllPanels()
    {
        for (int i =0; i< panelsPool.Count; i++)
        {
            GameObject panel = panelsPool[i];
            if (panel.activeSelf)
            {
                panel.SetActive(false);
            }
        }
    }

    public void InstantiateAllPanels()
    {
        for (int i = 0; i < GameManager.ExistingOvens.Length; i++)
        {
            GameObject panel = Instantiate(ovenControlPanelPrefab, GameObject.FindWithTag("Canvas").transform);
            panel.name = GameManager.ExistingOvens[i].name;
            panelsPool.Add(panel);
            panel.SetActive(false);
            panel.GetComponent<OvenControlPanel>().InitializeFields();
        }
    }
}
