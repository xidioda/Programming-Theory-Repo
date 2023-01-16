using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloseButton : MonoBehaviour
{ 
    public void DoClose()
    {
        gameObject.SetActive(false);
    }
}
