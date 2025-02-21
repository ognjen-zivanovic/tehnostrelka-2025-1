using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LipolistManager : MonoBehaviour
{
    
    void Start()
    {
        GameObject uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManager.GetComponent<UIManager>().SetPanelVisible(false);
    }

}
