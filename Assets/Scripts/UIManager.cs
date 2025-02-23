using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text descriptionText;

    [SerializeField] GameObject textPanel;

    public void SetValues(string nameString, string descriptionString) {
        bool isVisible = nameString != "" && descriptionString != "";
        SetPanelVisible(isVisible);
        nameText.text = nameString;
        descriptionText.text = descriptionString;
    }

    public void SetPanelVisible(bool visible) {
        textPanel.SetActive(visible);
    }
}
